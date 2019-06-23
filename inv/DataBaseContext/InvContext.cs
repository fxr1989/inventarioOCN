using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext.ConfiguracionDB;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ProductoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
