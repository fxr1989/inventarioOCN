using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Formularios;
using System.Configuration;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            configuracion();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin login = new FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
                Application.Run(new FrmMenu());
            else
                Application.Exit();
        }

        static void configuracion()
        {
            var fileNamDb = Application.StartupPath + @"\INVOCN.mdf";
            var cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileNamDb + ";Integrated Security=True";

            Repositorios.Static.ConfiguracionDB.SetCadenaConexion(cadena);
        }
    }
}
