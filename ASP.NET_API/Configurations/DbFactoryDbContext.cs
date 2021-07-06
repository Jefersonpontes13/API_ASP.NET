using ASP.NET_API.Infraestruture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace ASP.NET_API.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class DbFactoryDbContext : IDesignTimeDbContextFactory<CursoDbContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public CursoDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);
            return contexto;
        }
    }
}