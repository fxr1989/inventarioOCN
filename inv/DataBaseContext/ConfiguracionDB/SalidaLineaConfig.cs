using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    class SalidaLineaConfig : EntityTypeConfiguration<SalidaLinea>
    {
        public SalidaLineaConfig()
        {
            HasKey(linea => linea.SalidaLineaID);
            Property(linea => linea.Observacion)
                .HasMaxLength(300);
        }
    }
}
