using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_API.Models.Usuarios
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginViewModelInput
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Login Obrigatório")]
        public string Login { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Senha Obrigatória")]
        public string Senha { get; set; }
    }
}
