using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Static
{
    public class ConfiguracionDB
    {
        public static void SetCadenaConexion(string cadena)
        {
            DataBaseContext.Static.ConfiguracionDB.CadenaConexion = cadena;
        }

        public static string GetCadenaConexion()
        {
            return DataBaseContext.Static.ConfiguracionDB.CadenaConexion;
        }
    }
}
