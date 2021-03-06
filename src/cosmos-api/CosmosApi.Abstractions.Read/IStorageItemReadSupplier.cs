using System;
using System.Threading;
using System.Threading.Tasks;

namespace GGroupp.Infra.Bot.Builder;

public interface IStorageItemReadSupplier : IDisposable
{
    ValueTask<Result<StorageItemReadOut, StorageItemReadFailure>> ReadItemAsync(
        StorageItemPath path, CancellationToken cancellationToken = default);
}