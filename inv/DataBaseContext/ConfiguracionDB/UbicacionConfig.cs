using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class UbicacionConfig : EntityTypeConfiguration<Ubicacion>
    {
        public UbicacionConfig()
        {
            HasKey(ubicacion => ubicacion.UbicacionID);
            HasIndex(ubicacion => ubicacion.Nombre).IsUnique(true);
            Property(ubicacion => ubicacion.Nombre).HasMaxLength(100);
        }
    }
}
