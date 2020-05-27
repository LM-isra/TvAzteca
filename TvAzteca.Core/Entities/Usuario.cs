using System;
using System.ComponentModel.DataAnnotations;

namespace TvAzteca.Core.Entities
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        public string Nombre{ get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        public string Pass { get; set; }
    }
}
