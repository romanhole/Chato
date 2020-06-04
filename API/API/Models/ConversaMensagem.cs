using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class ConversaMensagem
    {
        [Key]
        public int idConversaMensagem { get; set; }
        public int idUsuario { get; set; }
        public int idConversa {get;set;}
        public string Mensagem { get; set; }
        public DateTime dataEnvio { get; set; }

    }
}
