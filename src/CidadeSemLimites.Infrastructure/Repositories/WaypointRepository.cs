using CidadeSemLimites.Domain.Entities;
using CidadeSemLimites.Domain.Repositories.Waypoints;
using CidadeSemLimites.Infrastructure.DataAccess;

namespace CidadeSemLimites.Infrastructure.Repositories
{
    public class WaypointRepository : IWaypointsReadOnlyRepository, IWaypointsUpdateRepository, IWaypointWriteOnlyRepository
    {
        private readonly CidadeSemLimitesDbContext _dbContext;
        public WaypointRepository(CidadeSemLimitesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Waypoints waypoints)
        {
            await _dbContext.Waypoints.AddAsync(waypoints);
        }
    }
}
