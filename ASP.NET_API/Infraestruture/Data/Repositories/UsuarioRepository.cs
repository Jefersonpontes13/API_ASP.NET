using ASP.NET_API.Business.Entities;
using ASP.NET_API.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_API.Infraestruture.Data;

namespace ASP.NET_API.Infraestruture.Data.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CursoDbContext _contexto;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contexto"></param>
        public UsuarioRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        public void Adicionar(Usuario usuario)
        {
            _contexto.Usuario.Add(usuario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {
            _contexto.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<Usuario> ObterUsuarioAsync(string login)
        {
            return await _contexto.Usuario.FirstOrDefaultAsync(u => u.Login == login);
        }
    }
}
