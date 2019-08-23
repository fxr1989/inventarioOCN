using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EntradaLinea
    {
        public int EntradaLineaID { get; set; }
        public int entradaID { get; set; }
        public int productoID { get; set; }
        public int ubicacionID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public bool Donacion { get; set; }
        public string Observacion { get; set; }
        public int monedaID { get; set; }
        public DateTime FechaIngreso { get; set; }
        public virtual Entrada entrada { get; set; }
        public virtual Producto producto { get; set; }
        public virtual Ubicacion ubicacion { get; set; }
        public virtual Moneda moneda { get; set; }

    }
}
