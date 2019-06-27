using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class EntradaConfig : EntityTypeConfiguration<Entrada>
    {
        public EntradaConfig()
        {
            HasKey(entrada => entrada.EntradaID);
        }
    }
}
