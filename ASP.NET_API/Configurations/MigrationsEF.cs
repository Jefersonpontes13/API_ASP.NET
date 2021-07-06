using ASP.NET_API.Infraestruture.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_API.Configurations
{
    public static class EntityFrameworkExtensions
    {
        public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var cursoDbContext = serviceScope.ServiceProvider.GetService<CursoDbContext>())
                {
                    var migracoesPendentes = cursoDbContext.Database.GetPendingMigrations();

                    if (migracoesPendentes.Count() == 0)
                    {
                        return app;
                    }

                    cursoDbContext.Database.Migrate();
                }
            }
            return app;
        }
    }
}
