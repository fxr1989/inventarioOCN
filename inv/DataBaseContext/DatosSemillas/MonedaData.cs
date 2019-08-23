using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext;
using System.Data.Entity.Migrations;

namespace DataBaseContext
{
    public class MonedaData
    {
        private readonly InvContext db;

        public MonedaData(InvContext context)
        {
            db = context ?? new InvContext();
        }
        public void GenerarData()
        {
            List<Moneda> monedas = new List<Moneda>();
            monedas.Add(new Moneda()
            {
                MonedaID = 1,                
                Nombre = "Cordoba",
                Simbolo = "C$"
            });
            monedas.Add(new Moneda()
            {
                MonedaID = 2,
                Nombre = "Dolar",
                Simbolo = "$"
            });
            foreach (var moneda in monedas)
            {
                if (!db.Monedas.Where(r => r.Nombre.ToUpper() == moneda.Nombre.ToUpper()).Any())
                    db.Monedas.AddOrUpdate(moneda);
            }
        }
    }
}
