using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    public class RolAccesoConfig : EntityTypeConfiguration<RolAcceso>
    {
        public RolAccesoConfig()
        {
            HasKey(acceso => acceso.RolAccesoID);            
        }
    }
}
