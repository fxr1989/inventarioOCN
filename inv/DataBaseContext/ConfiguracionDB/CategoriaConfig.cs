using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DataBaseContext.ConfiguracionDB
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(categoria => categoria.CategoriaID);
            HasIndex(categoria => categoria.Nombre).IsUnique();
            Property(categoria => categoria.Nombre)
                .IsUnicode()
                .HasMaxLength(150)
                .IsRequired();            
        }
    }
}
