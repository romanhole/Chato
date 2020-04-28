using System;
using System.Collections.Generic;
using System.Text;
using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Mensagem>()
        .HasOne<AppUser>(a => a.Remetente)
        .WithMany(d => d.Mensagens)
        .HasForeignKey(d => d.UserID);
    }
  }
}
