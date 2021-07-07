using ASP.NET_WEB.MVC.Models.Cursos;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_WEB.MVC.Services
{
    public interface ICursoService
    {
        [Post("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<CadastrarCursoViewModelOutput> Registrar(CadastrarCursoViewModelInput CadastrarCursoViewModelInput);

        [Get("/api/v1/cursos")]
        [Headers("Authorization: Bearer")]
        Task<IList<ListarCursoViewModelOutput>> Obter();
    }
}
