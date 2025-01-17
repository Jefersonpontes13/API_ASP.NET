﻿using System.ComponentModel.DataAnnotations;

namespace ASP.NET_WEB.MVC.Models.Cursos
{
    public class CadastrarCursoViewModelInput
    {
        [Required(ErrorMessage = "O nome do curso é obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "A descrição do curso é obrigatória")]
        public string Descricao { get; set; }
    }
}
