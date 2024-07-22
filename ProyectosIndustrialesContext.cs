using APITestCesar.Models;
using Microsoft.EntityFrameworkCore;

namespace APITestCesar
{
    public class ProyectosIndustrialesContext : DbContext
    {

        public ProyectosIndustrialesContext(DbContextOptions<ProyectosIndustrialesContext> options) : base(options)
        {
        }


        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleProyecto> DetalleProyectos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Encargado> Encargados { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleProyecto>().HasKey(dp => new { dp.ProyectoId, dp.ClienteId });

        }
    }
}
