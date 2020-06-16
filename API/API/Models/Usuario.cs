using System;
using System.ComponentModel.DataAnnotations;
namespace API.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string fotoPerfil { get; set; }
    }
}
