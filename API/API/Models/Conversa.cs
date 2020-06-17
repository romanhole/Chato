using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Conversa
    {
        [Key]
        public int idConversa { get; set; }
        public string nomeConversa { get; set; }

        public int isGrupo { get; set; }
    }
}
