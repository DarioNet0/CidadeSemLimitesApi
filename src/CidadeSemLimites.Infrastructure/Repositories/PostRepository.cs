using CidadeSemLimites.Domain.Entities;
using CidadeSemLimites.Domain.Repositories;
using CidadeSemLimites.Domain.Repositories.Posts;
using CidadeSemLimites.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Posts>> GetAll()
        {
            return await _dbContext.Posts.AsNoTracking().OrderByDescending(post => post.CreatedAt).ToListAsync();
        }

        public async Task<List<Posts>> GetByDescription(string searchKey)
        {
            return await _dbContext.Posts
                .AsNoTracking()
                .Where(post => post.Description.Contains(searchKey))
                .OrderByDescending(post => post.CreatedAt)
                .ToListAsync();
        }
    }
}
