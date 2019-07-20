using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class PermisoConfig : EntityTypeConfiguration<Permiso>
    {
        public PermisoConfig()
        {
            HasKey(permiso => permiso.PermisoID);
            HasIndex(permiso => permiso.Nombre)
                .IsUnique(true);
            Property(permiso => permiso.Nombre)
                .HasMaxLength(100);
        }
    }
}
