using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class InventarioDto
    {
        public int InventarioID { get; set; }
        public int productoID { get; set; }
        public int ubicacionID { get; set; }
        public string Producto { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }        
    }
}
