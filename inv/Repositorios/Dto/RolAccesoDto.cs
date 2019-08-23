using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class RolAccesoDto
    {
        public int RolAccesoID { get; set; }
        public int RolID { get; set; }
        public int PermisoID { get; set; }
        public string Rol { get; set; }
        public string Permiso { get; set; }
        public bool Agregar { get; set; }
        public bool Editar { get; set; }
        public bool Eliminar { get; set; }
        public bool Ver { get; set; }
    }
}
