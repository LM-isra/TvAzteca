using System;
using System.ComponentModel.DataAnnotations;

namespace TvAzteca.Api.Models
{
    public class UsuarioViewModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}
