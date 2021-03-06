using AElf.Kernel;

namespace AElf.CrossChain.Cache
{
    // todo : generic type
    public interface ICrossChainDataConsumer
    {
        T TryTake<T>(int crossChainId, long height, bool isCacheSizeLimited);
        int GetCachedChainCount();
        void TryRegisterNewChainCache(int remoteChainId, long chainHeight = KernelConstants.GenesisBlockHeight);
        bool CheckAlreadyCachedChain(int remoteChainId);
    }
}