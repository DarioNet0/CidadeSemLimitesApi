using CidadeSemLimites.Domain.Entities;
using CidadeSemLimites.Domain.Repositories;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Infrastructure.DataAccess;

namespace CidadeSemLimites.Infrastructure.Repositories
{
    public class PostRepository : IPostUpdateOnlyRepository, IPostWriteOnlyRepository, IPostReadOnlyRepository
    {
        private readonly CidadeSemLimitesDbContext _dbContext;
        public PostRepository(CidadeSemLimitesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Posts post)
        {
            await _dbContext.Posts.AddAsync(post);
        }
    }
}
