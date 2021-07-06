using System.ComponentModel.DataAnnotations;

namespace ASP.NET_API.Models.Cursos
{
    /// <summary>
    /// 
    /// </summary>
    public class CursoViewModelInput
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "O nome do curso é obrigatório")]
        public string Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "A descrição é obrigatória")]
        public string Descricao { get; set; }
    }
}