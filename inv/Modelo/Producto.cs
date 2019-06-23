using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Modelo { get; set; }
        public int categoriaID { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
