using CidadeSemLimites.Domain;
using CidadeSemLimites.Infrastructure.DataAccess;

namespace CidadeSemLimites.Infrastructure
{
    public class UnityOfWork : IUnitOfWork
    {
        private readonly CidadeSemLimitesDbContext _dbContext;
        public UnityOfWork(CidadeSemLimitesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
