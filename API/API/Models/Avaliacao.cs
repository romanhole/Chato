using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
  public class Avaliacao
  {
    [Key]
    public int codAvaliacao { get; set; }
    public int nota { get; set; }
    public String comentario { get; set; }
  }
}
