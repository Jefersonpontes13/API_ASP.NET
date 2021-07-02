using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_API.Models;
using ASP.NET_API.Models.Usuarios;
using Swashbuckle.AspNetCore.Annotations;

namespace ASP.NET_API.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <sumary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </sumary>
        /// <param name="loginViewModelInput">View Model do Login</param>
        /// <returns>retorna Status okm dados do usuário e o token em caso de sucesso</returns>
        
        
        [SwaggerResponse(statusCode: 200, description:"Sucesso ao Autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description:"Campos Obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description:"Erro Interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }
        
        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
