using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataBaseContext;
using Repositorios.Dto;
using Repositorios.Interface;

namespace Repositorios
{
    public class RolAccesoRepositorio: Repositorio<RolAcceso>
    {
        public RolAccesoRepositorio(): base()
        {

        }
        public RolAccesoRepositorio(InvContext contexto): base(contexto)
        {

        }

        public void ActualizarMultiRolAcceso(List<RolAccesoDto> rolesAccesos)
        {
            var transaccionDb = db.Database.BeginTransaction();
            try
            {
                var listaIds = rolesAccesos.Select(ra => ra.RolAccesoID).ToArray();
                var listaRolAcceso = db.RolesAcceso.Where(ra => listaIds.Contains(ra.RolAccesoID));
                foreach (var rolAcceso in rolesAccesos)
                {
                    var updateRolAcceso = listaRolAcceso.FirstOrDefault(ra => ra.RolAccesoID == rolAcceso.RolAccesoID);

                    if (updateRolAcceso == null) continue;
                    updateRolAcceso.Agregar = rolAcceso.Agregar;
                    updateRolAcceso.Editar = rolAcceso.Editar;
                    updateRolAcceso.Eliminar = rolAcceso.Eliminar;
                    updateRolAcceso.Ver = rolAcceso.Ver;
                    
                    db.Entry(updateRolAcceso).State = System.Data.Entity.EntityState.Modified;
                }
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
