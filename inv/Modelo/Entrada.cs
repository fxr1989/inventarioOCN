using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Entrada
    {
        public int EntradaID { get; set; }
        public DateTime Fecha { get; set; }
        public int usuarioID { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDonaciones { get; set; }
        public DateTime FechaIngreso { get; set; }
        public virtual ICollection<EntradaLinea> lineas { get; set; }
        public virtual Usuario usuario { get; set; }

    }
}
