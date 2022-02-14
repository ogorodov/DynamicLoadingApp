using DynamicLoadingApp.Infrastructure.Db;
using FluentAssertions;
using Xunit;

namespace Infrastructure.Db.IntegrationTests
{
    
    public class TestCommentsProvider
    {
        [Fact]
        public async Task TestGetCommentsAsync()
        {
            var myDbContext = new MyDbContext();
            var commentsProvider = new CommentsProvider(myDbContext);

            var comments = await commentsProvider.GetCommentsAsync(default);

            comments.Should().HaveCount(25);
        }
    }
}