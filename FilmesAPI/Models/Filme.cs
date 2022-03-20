using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatorio!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Diretor é obrigatorio!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duração não deve estar entre 1 a 600 minutos")]
        public int Duracao { get; set; }
    }
}
