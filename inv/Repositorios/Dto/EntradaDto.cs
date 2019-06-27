using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class EntradaDto
    {
        public int EntradaID { get; set; }
        public DateTime Fecha { get; set; }
        public int usuarioID { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDonaciones { get; set; }
        public DateTime FechaIngreso { get; set; }
        public  List<EntradaLineaDto> lineas { get; set; }
        public string   NombreUsuario { get; set; }
        public EntradaDto()
        {
            lineas = new List<EntradaLineaDto>();
        }
    }
}
