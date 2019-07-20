using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Rol
    {
        public int RolID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<RolAcceso> accesos { get; set; }
        public virtual ICollection<Usuario> usuarios { get; set; }
    }
}
