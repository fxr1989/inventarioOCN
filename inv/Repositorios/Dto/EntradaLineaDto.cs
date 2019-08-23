using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class EntradaLineaDto
    {
        public int EntradaLineaID { get; set; }
        public int entradaID { get; set; }
        public int productoID { get; set; }
        public int ubicacionID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total
        {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
        public bool Donacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Observacion { get; set; }
        public int monedaID { get; set; }
    }
}
