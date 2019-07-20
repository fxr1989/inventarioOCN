using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RolAcceso
    {
        public int RolAccesoID { get; set; }
        public int rolID { get; set; }
        public int permisoID { get; set; }
        public bool Agregar { get; set; }
        public bool Editar { get; set; }
        public bool Eliminar { get; set; }
        public bool Ver { get; set; }
        public virtual Rol rol { get; set; }
        public virtual Permiso permiso { get; set; }
    }
}
