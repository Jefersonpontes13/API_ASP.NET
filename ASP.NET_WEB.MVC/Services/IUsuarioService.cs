using ASP.NET_WEB.MVC.Models.Usuarios;
using Refit;
using System.Threading.Tasks;

namespace ASP.NET_WEB.MVC.Services
{
    public interface IUsuarioService
    {
        [Post("/api/v1/usuario/registrar")]
        Task<RegistrarUsuarioViewModelInput> Registrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput);

        [Post("/api/v1/usuario/logar")]
        Task<LoginViewModelOutput> Logar(LoginViewModelInput loginViewModelInput);
    }
}
