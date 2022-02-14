using DynamicLoadingApp.Core.Domain;

namespace DynamicLoadingApp.Core.ForeignServices;

public interface ICommentsProvider
{
    public Task<IList<Comment>> GetCommentsAsync(CancellationToken cancellationToken);
}