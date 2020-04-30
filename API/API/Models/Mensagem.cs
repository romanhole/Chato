using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Mensagem
  {
    public int Id { get; set; }
    [Required]

    public string NomeUsuario { get; set; }
    [Required]
    public string Texto { get; set; }
    public DateTime Horario { get; set; }
    public string UserID { get; set; }
    public virtual AppUser Remetente { get; set; }

    public Mensagem()
    {
      Horario = DateTime.Now;
    }
  }
}
