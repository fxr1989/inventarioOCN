using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class RolConfig : EntityTypeConfiguration<Rol>
    {
        public RolConfig()
        {
            HasKey(rol => rol.RolID);
            HasIndex(rol => rol.Nombre)
                .IsUnique(true);
            Property(rol => rol.Nombre)
                .HasMaxLength(200);
        }
    }
}
