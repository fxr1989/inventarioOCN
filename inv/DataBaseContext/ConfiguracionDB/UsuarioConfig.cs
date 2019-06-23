using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace DataBaseContext.ConfiguracionDB
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(usuario => usuario.UsuarioID);
            HasIndex(usuario => usuario.NombreUsuario)
                .IsUnique(true);
            Property(usuario => usuario.NombreUsuario)
                .IsUnicode()
                .HasMaxLength(50)
                .IsRequired();
            Property(usuario => usuario.Nombres)
                .HasMaxLength(50)
                .IsRequired();
            Property(usuario => usuario.Apellidos)
                .HasMaxLength(50)
                .IsRequired();
            Property(usuario => usuario.Correo)
                .IsUnicode()
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
