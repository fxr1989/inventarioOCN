using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DataBaseContext.ConfiguracionDB
{
    public class AreaConfig : EntityTypeConfiguration<Area>
    {
        public AreaConfig()
        {
            HasKey(area => area.AreaID);
            HasIndex(area => area.Nombre)
                .IsUnique(true);
            Property(area => area.Nombre)
                .IsUnicode()
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
