using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataBaseContext;
using Modelo;

namespace Repositorios
{
    public class UsuarioRepositorio : Repositorio<Usuario>
    {
        public UsuarioRepositorio(): base()
        {

        }

        public UsuarioRepositorio(InvContext context): base(context)
        {

        }

        public override void Agregar(Usuario entidad)
        {
            entidad.Password = EncriptarPassword(entidad.Password);
            base.Agregar(entidad);
        }
        public override void Actualizar(Usuario entidad)
        {
            if (entidad.Password.Length > 0)
                entidad.Password = EncriptarPassword(entidad.Password);
            base.Actualizar(entidad);
        }

        public Usuario Login(string nombreUsuario, string password)
        {
            var passwordEncriptada = EncriptarPassword(password);
            var usuarioResultado = db
                                    .Usuarios
                                    .Include("area")
                                    .Include("rol")
                                    .FirstOrDefault(usuario => usuario.NombreUsuario == nombreUsuario && usuario.Password == passwordEncriptada);
            return usuarioResultado;
        }

        private string EncriptarPassword(string password)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
