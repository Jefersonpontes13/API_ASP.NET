using ASP.NET_API.Business.Entities;
using System.Threading.Tasks;

namespace ASP.NET_API.Business.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        void Adicionar(Usuario usuario);
        /// <summary>
        /// 
        /// </summary>
        void Commit();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<Usuario> ObterUsuarioAsync(string login);
    }
}
