using Classify.Core.Models;

namespace Classify.Core.Contracts
{
    public interface IComposerService
    {
        Task<IEnumerable<ComposerDisplayModel>> AllDisplayAsync();
    }
}
