using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Repositorios.Interface;
using DataBaseContext;

namespace Repositorios
{
    public class EntradaRepositorio : Repositorio<Entrada>
    {
        public IRepositorio<Ubicacion> ubicacion;
        public IRepositorio<Producto> producto;
        public IRepositorio<Moneda> moneda;
        public InventarioRepositorio inventario;

        public EntradaRepositorio(): base()
        {
            ubicacion = new Repositorio<Ubicacion>(db);
            producto = new Repositorio<Producto>(db);
            moneda = new Repositorio<Moneda>(db);
            inventario = new InventarioRepositorio(db);
        }

        public EntradaRepositorio(InvContext context): base(context)
        {
            ubicacion = new Repositorio<Ubicacion>(db);
            producto = new Repositorio<Producto>(db);
            inventario = new InventarioRepositorio(db);
        }

        public override void Agregar(Entrada entrada)
        {
            var transaccionDb = db.Database.BeginTransaction();
            try
            {
                db.Entradas.Add(entrada);
                db.SaveChanges();

                inventario.EntradaMovimiento(entrada);
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
