using GranDanesWebApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GranDanesWebApp.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteRol> ClienteRoles { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteRol>()
                .HasKey(cr => new { cr.ClienteID, cr.RolID });

            modelBuilder.Entity<ClienteRol>()
                .HasOne(cr => cr.Cliente)
                .WithMany(c => c.ClienteRoles)
                .HasForeignKey(cr => cr.ClienteID);

            modelBuilder.Entity<ClienteRol>()
                .HasOne(cr => cr.Rol)
                .WithMany(r => r.ClienteRoles)
                .HasForeignKey(cr => cr.RolID);
        }

    }
}
