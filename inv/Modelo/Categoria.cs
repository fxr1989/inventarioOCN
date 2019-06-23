using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
