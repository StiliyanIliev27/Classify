using Classify.Core.Models;

namespace Classify.Core.Contracts
{
    public interface IPieceService
    {
        Task<IEnumerable<PieceViewModel>> AllById(int composerId);
    }
}
