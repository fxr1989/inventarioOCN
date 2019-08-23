using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Modelo;

namespace DataBaseContext.ConfiguracionDB
{
    public class MarcaConfig : EntityTypeConfiguration<Marca>
    {
        public MarcaConfig()
        {
            HasKey(marca => marca.MarcaID);
            HasIndex(marca => marca.Nombre).IsUnique(true);
            Property(marca => marca.Nombre)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
