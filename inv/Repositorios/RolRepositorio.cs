using DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorios.Dto;
using Modelo;

namespace Repositorios
{
    public class RolRepositorio
    {
        public InvContext db;
        public readonly RolAccesoRepositorio repositorioRolAcceso;

        public RolRepositorio()
        {
            db = new InvContext();
            repositorioRolAcceso = new RolAccesoRepositorio(db);
        }

        public List<RolAccesoDto> ObtenerRoles()
        {
            var roles = (
                            from rolAcceso in db.RolesAcceso
                            join rol in db.Roles on rolAcceso.rolID equals rol.RolID
                            join permiso in db.Permisos on rolAcceso.permisoID equals permiso.PermisoID
                            select new RolAccesoDto
                            {
                                RolAccesoID = rolAcceso.RolAccesoID,
                                RolID = rolAcceso.rolID,
                                PermisoID = rolAcceso.permisoID,
                                Permiso = permiso.Nombre,
                                Rol = rol.Nombre,
                                Agregar = rolAcceso.Agregar,
                                Editar = rolAcceso.Editar,
                                Eliminar = rolAcceso.Eliminar,
                                Ver = rolAcceso.Ver
                            }
                        ).ToList();
            return roles;
        }

        public void AgregarRol(Rol rol)
        {
            var transaccionDb = db.Database.BeginTransaction();
            try
            {
                var existeRol = db.Roles.FirstOrDefault(rolBuscar => rolBuscar.Nombre.ToUpper() == rol.Nombre.ToUpper());
                if (existeRol != null)
                    throw new ArgumentException($"El rol {rol.Nombre} ya existe");


                db.Roles.Add(rol);
                db.SaveChanges();

                var permisos = db.Permisos.ToList();
                foreach (var permiso in permisos)
                {
                    db.RolesAcceso.Add(new RolAcceso() { rolID = rol.RolID, permisoID = permiso.PermisoID, Agregar = false, Editar = false, Eliminar = false, Ver = false });
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
