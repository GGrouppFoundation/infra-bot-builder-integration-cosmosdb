using System;
using System.Threading;
using System.Threading.Tasks;

namespace GGroupp.Infra.Bot.Builder;

public interface IStorageItemWriteSupplier : IDisposable
{
    ValueTask<Result<Unit, StorageItemWriteFailure>> WriteItemAsync(
        StorageItemWriteIn input, CancellationToken cancellationToken = default);
}