using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_API.Models.Usuarios;

namespace ASP.NET_API.Controllers
{
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <sumary>
        /// teste
        /// </sumary>
        /// <param name="loginViewModelInput"></param>
        /// <returns></returns>

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
