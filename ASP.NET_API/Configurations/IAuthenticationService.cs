using ASP.NET_API.Models.Usuarios;

namespace ASP.NET_API.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioViewModelOutput"></param>
        /// <returns></returns>
        string GerarToken(UsuarioViewModelOutput usuarioViewModelOutput);
    }
}
