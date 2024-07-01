using Classify.Core.Contracts;
using Classify.Core.Models;
using Classify.Infrastructure.Common;
using Classify.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Classify.Core.Services
{
    public class AudioService : IAudioService
    {
        private readonly IRepository repository;

        public AudioService(IRepository repository)
        {
            this.repository = repository;    
        }

        public async Task<AudioFileDto?> FindByIdAsync(int pieceId)
        {
            return await repository.AllReadOnly<Piece>()
                .Where(p => p.Id == pieceId)
                .Select(af => new AudioFileDto()
                {
                    PieceId = af.Id,
                    AudioFile = af.AudioFile,
                    AudioFileContentType = af.AudioFileContentType,
                    AudioFileName = af.AudioFileName
                })
                .FirstOrDefaultAsync();
        }

        public async Task RemoveAsync(int pieceId)
        {
            var piece = await repository.All<Piece>().Where(p => p.Id == pieceId).FirstOrDefaultAsync();

            if(piece != null)
            {
                if(piece.AudioFile != null)
                {
                    piece.AudioFile = null;
                    piece.AudioFileName = null;
                    piece.AudioFileContentType = null;

                    await repository.SaveChangesAsync();
                }
            }
        }

        public async Task<bool> UploadAsync(IFormFile file, int pieceId)
        {
            if(file != null && file.Length > 0 && file.ContentType == "audio/mpeg")
            {
                var piece = await repository.All<Piece>().Where(p => p.Id == pieceId).FirstOrDefaultAsync();
                
                if(piece != null)
                {
                    if(piece.AudioFile != null)
                    {
                        return false;
                    }

                    piece.AudioFileName = Path.GetFileName(file.FileName);
                    piece.AudioFileContentType = file.ContentType;

                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        piece.AudioFile = memoryStream.ToArray();
                    }

                    await repository.SaveChangesAsync();
                    return true;
                }
            }

            return false;
        }
    }
}
