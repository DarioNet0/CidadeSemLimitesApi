using CidadeSemLimites.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CidadeSemLimites.Infrastructure.DataAccess
{
    public class CidadeSemLimitesDbContext : DbContext
    {
        public CidadeSemLimitesDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SiteFeedback> SiteFeedbacks { get; set; }
    }
}
