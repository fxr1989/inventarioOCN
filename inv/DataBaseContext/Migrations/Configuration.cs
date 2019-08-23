namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Modelo;
    using DatosSemillas;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<DataBaseContext.InvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataBaseContext.InvContext context)
        {
            RolData roles = new RolData(context);
            roles.GenerarData();
            AreaData areas = new AreaData(context);
            areas.GenerarData();
            PermisoData permisos = new PermisoData(context);
            permisos.GenerarData();
            
            var usuarioAdmin = new Usuario()
            {
                UsuarioID = 1,
                NombreUsuario = "nadia",
                Nombres = "Nadia",
                Apellidos = "Nabhan",
                Password = EncriptarPassword("123"),
                Correo = "Nadia.Nabhan@operationsmile.org",
                rolID = 1,
                AreaID = 1                
            };
            if (!context.Usuarios.Where(usuario =>usuario.NombreUsuario == usuarioAdmin.NombreUsuario).Any())
                context.Usuarios.AddOrUpdate(usuarioAdmin);
            MonedaData monedaData = new MonedaData(context);
            monedaData.GenerarData();

            context.SaveChanges();
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
