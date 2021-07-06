using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using ASP.NET_API.Models;

namespace ASP.NET_API.Models.Usuarios
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginViewModelOutput
    {
        /// <summary>
        /// 
        /// </summary>
        public string Token { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public UsuarioViewModelOutput Usuario { get; set; }
    }
}