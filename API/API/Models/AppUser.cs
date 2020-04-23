using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class AppUser : IdentityUser
  {
    public AppUser()
    {
      Mensagens = new HashSet<Mensagem>();
    }
    // AppUser || Mensagem
    public virtual ICollection<Mensagem> Mensagens { get; set; }
  }
}
