namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CamposUnicosArea_Nombre_Usuario_NombreUsuario_Correo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Correo", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Correo", c => c.String());
        }
    }
}
