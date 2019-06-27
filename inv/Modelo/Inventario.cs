using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Inventario
    {
        public int InventarioID { get; set; }
        public int productoID { get; set; }
        public int ubicacionID { get; set; }
        public int Cantidad { get; set; }
        public virtual Producto producto { get; set; }
        public virtual Ubicacion ubicacion { get; set; }
    }
}
