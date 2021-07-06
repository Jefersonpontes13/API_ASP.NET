using ASP.NET_API.Business.Entities;
using ASP.NET_API.Infraestruture.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_API.Infraestruture.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class CursoDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public CursoDbContext(DbContextOptions<CursoDbContext> options) :base(options)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Usuario> Usuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Curso> Curso { get; set; }
    }
}