using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SalidaLinea
    {
        public int SalidaLineaID { get; set; }
        public int salidaID { get; set; }
        public int productoID { get; set; }
        public int ubicacionID { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public virtual Salida salida { get; set; }
        public virtual Producto producto { get; set; }
        public virtual Ubicacion ubicacion { get; set; }
    }
}
