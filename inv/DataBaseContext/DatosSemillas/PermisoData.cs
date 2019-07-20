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
                    Nombre = "Area"
                },
                new Permiso()
                {
                    PermisoID = 2,
                    Nombre = "Categoria"
                },
                new Permiso()
                {
                    PermisoID = 3,
                    Nombre = "Producto"
                },
                new Permiso()
                {
                    PermisoID = 4,
                    Nombre = "Usuario"
                },
                new Permiso()
                {
                    PermisoID = 5,
                    Nombre = "Rol"
                },
                new Permiso()
                {
                    PermisoID = 6,
                    Nombre = "Ubicación"
                },
                new Permiso()
                {
                    PermisoID = 7,
                    Nombre = "Entrada Inventario"
                },
                new Permiso()
                {
                    PermisoID = 8,
                    Nombre = "Salida Inventario"
                }
            };
            foreach (var permiso in permisos)
            {
                if (!db.Permisos.Where(r => r.Nombre.ToUpper() == permiso.Nombre.ToUpper()).Any())
                    db.Permisos.AddOrUpdate(permiso);
            }
        }
    }
}
