using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.ConfiguracionDB
{
    class InventarioConfig : EntityTypeConfiguration<Inventario>
    {
        public InventarioConfig()
        {            
            HasKey(inventario => new { inventario.productoID, inventario.ubicacionID });            
        }
    }
}
