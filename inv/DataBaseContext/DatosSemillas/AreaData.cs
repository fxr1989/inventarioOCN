using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.Entity.Migrations;

namespace DataBaseContext.DatosSemillas
{
    public class AreaData
    {
        private readonly InvContext db;

        public AreaData(InvContext context)
        {
            db = context ?? new InvContext();
        }
        public void GenerarData()
        {
            List<Area> areas = new List<Area>();
            areas.Add(new Area()
            {
                AreaID = 1,
                Nombre = "Sistema"
            });
            foreach (var area in areas)
            {
                if (!db.Roles.Where(a => a.Nombre.ToUpper() == area.Nombre.ToUpper()).Any())
                    db.Areas.AddOrUpdate(area);
            }
        }
    }
}
