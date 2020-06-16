using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class UsuarioConversa
  {
    [Key]
    public int id { get; set; }
    public int idUsuario { get; set; }
    public int idConversa { get; set; }

  }
}
