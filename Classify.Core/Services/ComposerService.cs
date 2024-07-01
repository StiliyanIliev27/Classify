using Classify.Core.Contracts;
using Classify.Core.Models;
using Classify.Infrastructure.Common;
using Classify.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Classify.Core.Services
{
    public class ComposerService : IComposerService
    {
        private readonly IRepository repository;

        public ComposerService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ComposerDisplayModel>> AllDisplayAsync()
        {
            return await repository.AllReadOnly<Composer>()
                .Select(c => new ComposerDisplayModel()
                {
                    Id = c.Id,
                    FullName = $"{c.FirstName} {c.LastName}",
                    ImageUrl = c.ImageUrl
                }).ToListAsync();
        }
    }
}
