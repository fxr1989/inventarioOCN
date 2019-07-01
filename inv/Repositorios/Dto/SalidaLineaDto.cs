using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class SalidaLineaDto
    {
        public int SalidaLineaID { get; set; }
        public int entradaID { get; set; }
        public int productoID { get; set; }
        public string NombreProducto { get; set; }
        public int ubicacionID { get; set; }
        public string NombreUbicacion { get; set; }
        public int Disponible { get; set; }
        public int Cantidad { get; set; }        
        public DateTime FechaIngreso { get; set; }
        public string Observacion { get; set; }
    }
}
