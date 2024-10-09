using CidadeSemLimites.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CidadeSemLimites.Infrastructure.DataAccess
{
    public class CidadeSemLimitesDbContext : DbContext
    {
        public CidadeSemLimitesDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<SiteFeedbacks> SiteFeedbacks { get; set; }
        public DbSet<Waypoints> Waypoints { get; set; }

    }
}
