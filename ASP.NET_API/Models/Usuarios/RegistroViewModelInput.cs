﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_API.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "Login Obrigatório")]
        public string Login { get; set; }
        
        [Required(ErrorMessage = "E-mail Obrigatório")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Senha Obrigatória")]
        public string Senha { get; set; }
    }
}