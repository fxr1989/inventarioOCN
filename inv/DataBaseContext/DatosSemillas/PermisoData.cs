using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.Entity.Migrations;


namespace DataBaseContext.DatosSemillas
{
    public class PermisoData
    {
        private readonly InvContext db;

        public PermisoData(InvContext context)
        {
            db = context ?? new InvContext();
        }
        public void GenerarData()
        {
            List<Permiso> permisos = new List<Permiso>()
            {
                new Permiso()
                {
                    PermisoID = 1,
                    Nombre = "Area",
                    Formulario = "FrmArea"
                },
                new Permiso()
                {
                    PermisoID = 2,
                    Nombre = "Categoria",
                    Formulario = "FrmCategoria"
                },
                new Permiso()
                {
                    PermisoID = 3,
                    Nombre = "Producto",
                    Formulario = "FrmProducto"
                },
                new Permiso()
                {
                    PermisoID = 4,
                    Nombre = "Usuario",
                    Formulario = "FrmUsuario"
                },
                new Permiso()
                {
                    PermisoID = 5,
                    Nombre = "Rol",
                    Formulario = "FrmRoles"
                },
                new Permiso()
                {
                    PermisoID = 6,
                    Nombre = "Ubicación",
                    Formulario = "FrmUbicacion"
                },
                new Permiso()
                {
                    PermisoID = 7,
                    Nombre = "Entrada Inventario",
                    Formulario = "FrmEntrada"
                },
                new Permiso()
                {
                    PermisoID = 8,
                    Nombre = "Salida Inventario",
                    Formulario = "FrmSalida"
                },
                new Permiso()
                {
                    PermisoID = 9,
                    Nombre = "Inventario",
                    Formulario = "FrmInventario"
                },
                new Permiso()
                {
                    PermisoID = 10,
                    Nombre = "Reportes",
                    Formulario = "FrmReportes"
                },
                new Permiso()
                {
                    PermisoID = 11,
                    Nombre = "Marca",
                    Formulario = "FrmMarca"
                }
            };
            foreach (var permiso in permisos)
            {
                //if (!db.Permisos.Where(r => r.Nombre.ToUpper() == permiso.Nombre.ToUpper()).Any())
                    db.Permisos.AddOrUpdate(permiso);
            }
        }
    }
}
