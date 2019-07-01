using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Salida
    {
        public int SalidaID { get; set; }
        public DateTime Fecha { get; set; }
        public int usuarioID { get; set; }        
        public DateTime FechaIngreso { get; set; }
        public int CantidadTotal { get; set; }
        public virtual ICollection<SalidaLinea> lineas { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}
