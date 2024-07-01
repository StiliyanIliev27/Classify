using Classify.Core.Contracts;
using Classify.Core.Models;
using Classify.Infrastructure.Common;
using Classify.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Classify.Core.Services
{
    public class PieceService : IPieceService
    {
        private readonly IRepository repository;

        public PieceService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IEnumerable<PieceViewModel>> AllById(int composerId)
        {
            var pieces = await repository.AllReadOnly<Piece>()
                .Where(p => p.ComposerId == composerId)
                .Include(p => p.Composer)
                .Select(p => new PieceViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Type = p.Type.ToString(),
                    InstrumentType = p.InstrumentType.ToString(),
                    ComposerFullName = p.Composer.FirstName + " " + p.Composer.LastName, 
                    ComposerDescription = p.Composer.Description,
                    ComposerImageUrl = p.Composer.ImageUrl,
                    ComposerYearnBorn = p.Composer.YearnBorn,
                    AudioContentType = p.AudioFileContentType
                })
                .ToListAsync();

            return pieces;
        }
    }
}
