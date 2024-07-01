using Classify.Core.Models;
using Microsoft.AspNetCore.Http;

namespace Classify.Core.Contracts
{
    public interface IAudioService
    {
        Task<bool> UploadAsync(IFormFile file, int pieceId);
        Task RemoveAsync(int pieceId);
        Task<AudioFileDto?> FindByIdAsync(int pieceId);
    }
}
