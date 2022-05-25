using Microsoft.EntityFrameworkCore;
using WebCrudCremeb.Models;

namespace WebCrudCremeb.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<GrupoModel> Grupos { get; set; }
    }
}
