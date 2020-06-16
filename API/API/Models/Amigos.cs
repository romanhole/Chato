using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Amigos
  {
    [Key]
    public int NumDeRegistro { get; set; }
    public int idUsuario { get; set; }
    public int idAmigo { get; set; }
  }
}
