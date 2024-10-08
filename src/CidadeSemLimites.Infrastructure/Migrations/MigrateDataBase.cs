using CidadeSemLimites.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CidadeSemLimites.Infrastructure.Migrations
{
    public static class MigrateDataBase
    {
        public async static Task MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<CidadeSemLimitesDbContext>();

            await dbContext.Database.MigrateAsync();
        }
    }
}
