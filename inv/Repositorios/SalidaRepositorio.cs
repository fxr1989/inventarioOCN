using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Modelo;
using Repositorios.Interface;

namespace Repositorios
{
    public class SalidaRepositorio : Repositorio<Salida>
    {
        public IRepositorio<Ubicacion> ubicacion;
        public IRepositorio<Producto> producto;
        public InventarioRepositorio inventario;

        public SalidaRepositorio() : base()
        {
            ubicacion = new Repositorio<Ubicacion>(db);
            producto = new Repositorio<Producto>(db);
            inventario = new InventarioRepositorio(db);
        }

        public SalidaRepositorio(InvContext context) : base(context)
        {
            ubicacion = new Repositorio<Ubicacion>(db);
            producto = new Repositorio<Producto>(db);
            inventario = new InventarioRepositorio(db);
        }

        public override void Agregar(Salida salida)
        {
            var transaccionDb = db.Database.BeginTransaction();
            try
            {
                db.Salidas.Add(salida);
                db.SaveChanges();

                inventario.SalidaMovimiento(salida);
                db.SaveChanges();

                transaccionDb.Commit();
            }
            catch (Exception ex)
            {
                transaccionDb.Rollback();
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
