using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Conversa> Conversa {get;set;}
        public DbSet<ConversaMensagem> ConversaMensagem { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Amigos> Amigos { get; set; }
    }
}
