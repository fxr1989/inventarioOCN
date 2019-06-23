using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Area
    {
        public int AreaID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
