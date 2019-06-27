using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DataBaseContext.ConfiguracionDB
{
    public class ProductoConfig : EntityTypeConfiguration<Producto>
    {
        public ProductoConfig()
        {
            HasKey(producto => producto.ProductoID);
            HasIndex(producto => producto.Codigo).IsUnique(true);
            Property(producto => producto.Codigo)
                .HasMaxLength(50);
            Property(producto => producto.Nombre)                
                .HasMaxLength(50)
                .IsRequired();
            Property(producto => producto.Modelo)
                .HasMaxLength(100);
            Property(producto => producto.Descripcion)
                .HasMaxLength(300);
        }
    }
}
