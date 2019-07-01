using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Dto
{
    public class SalidaDto
    {
        public int SalidaID { get; set; }
        public DateTime Fecha { get; set; }
        public int usuarioID { get; set; }
        public DateTime FechaIngreso { get; set; }
        public List<SalidaLineaDto> lineas { get; set; }
        public string NombreUsuario { get; set; }
        public SalidaDto()
        {
            lineas = new List<SalidaLineaDto>();
        }
    }
}
