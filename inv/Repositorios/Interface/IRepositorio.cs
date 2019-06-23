using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.Interface
{
    public interface IRepositorio<T> where T: class
    {
        IQueryable<T> Obtener();
        IQueryable<T> Obtener(Expression<Func<T, bool>> exprecionLanda);
        T ObtenerUno(object id);
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void Guardar();
    }
}
