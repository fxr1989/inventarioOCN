using System;
using System.Collections.Generic;
using System.Linq;
using Repositorios.Interface;
using DataBaseContext;
using System.Linq.Expressions;

namespace Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected InvContext db;

        public Repositorio()
        {
            db = new InvContext();
        }

        public Repositorio(InvContext context)
        {
            db = context;
        }

        public virtual void Actualizar(T entidad)
        {
            db.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Agregar(T entidad)
        {
            db.Entry(entidad).State = System.Data.Entity.EntityState.Added;
        }

        public virtual void Eliminar(T entidad)
        {
            db.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
        }

        public virtual void Guardar()
        {
            db.SaveChanges();
        }

        public IQueryable<T> Obtener()
        {
            return db.Set<T>().AsQueryable();
        }
        public IQueryable<T> Obtener(Expression<Func<T, bool>> exprecionLanda)
        {
            return db.Set<T>()
                    .Where(exprecionLanda)
                    .AsQueryable();    
        }

        public T ObtenerUno(object id)
        {
            return db.Set<T>().Find(id);
        }

    }
}
