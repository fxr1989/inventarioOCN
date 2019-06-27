using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class EntradaLineaConfig : EntityTypeConfiguration<EntradaLinea>
    {
        public EntradaLineaConfig()
        {            
            HasKey(linea => linea.EntradaLineaID);
            Property(linea => linea.Observacion).HasMaxLength(300);
        }
    }
}
