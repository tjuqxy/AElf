using System.Threading.Tasks;
using AElf.Kernel;

// ReSharper disable once CheckNamespace
namespace AElf.ChainController
{
    public interface IBlockSyncService
    {
        Task<BlockValidationResult> ReceiveBlock(IBlock block);
        void AddMinedBlock(IBlock block);
    }
}