using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext.ConfiguracionDB;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataBaseContext
{
    public class InvContext : DbContext
    {
        public InvContext(): base("Presentacion.Properties.Settings.CadenaConexion")
        {

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<EntradaLinea> EntradaLineas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<SalidaLinea> SalidasLineas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Configurations.Add(new AreaConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ProductoConfig());
            modelBuilder.Configurations.Add(new UbicacionConfig());
            modelBuilder.Configurations.Add(new EntradaConfig());
            modelBuilder.Configurations.Add(new EntradaLineaConfig());
            modelBuilder.Configurations.Add(new InventarioConfig());
            modelBuilder.Configurations.Add(new SalidaConfig());
            modelBuilder.Configurations.Add(new SalidaLineaConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
