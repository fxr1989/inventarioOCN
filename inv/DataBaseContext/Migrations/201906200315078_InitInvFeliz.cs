namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitInvFeliz : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AreaID);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        NombreUsuario = c.String(nullable: false, maxLength: 50),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(),
                        Password = c.String(),
                        areaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .ForeignKey("dbo.Areas", t => t.areaID, cascadeDelete: true)
                .Index(t => t.areaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "areaID", "dbo.Areas");
            DropIndex("dbo.Usuarios", new[] { "areaID" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Areas");
        }
    }
}
