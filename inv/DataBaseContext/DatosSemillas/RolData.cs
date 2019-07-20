using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext;
using System.Data.Entity.Migrations;

namespace DataBaseContext.DatosSemillas
{
    public class RolData
    {
        private readonly InvContext db;

        public RolData(InvContext context)
        {
            db = context ?? new InvContext();
        }
        public void GenerarData()
        {
            List<Rol> roles = new List<Rol>();
            roles.Add(new Rol()
            {
                RolID = 1,
                Nombre = "Adminsitrador"
            });
            foreach (var rol in roles)
            {
                if (!db.Roles.Where(r => r.Nombre.ToUpper() == rol.Nombre.ToUpper()).Any())
                    db.Roles.AddOrUpdate(rol);
            }
        }
    }
}
