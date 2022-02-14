using DynamicLoadingApp.Core.Domain;
using DynamicLoadingApp.Core.ForeignServices;
using Microsoft.EntityFrameworkCore;

namespace DynamicLoadingApp.Infrastructure.Db;

public class CommentsProvider : ICommentsProvider
{
    private readonly MyDbContext _myDbContext;

    public CommentsProvider(MyDbContext myDbContext)
    {
        _myDbContext = myDbContext;
    }

    public async Task<IList<Comment>> GetCommentsAsync(CancellationToken cancellationToken)
    {
        return await _myDbContext.Comment
            .Where(o => o.Approved == "spam")
            .OrderByDescending(o => o.DateGmt)
            .Take(25)
            .ToListAsync(cancellationToken);
    }
}