namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuario_area_unique : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Usuarios", new[] { "areaID" });
            CreateIndex("dbo.Areas", "Nombre", unique: true);
            CreateIndex("dbo.Usuarios", "NombreUsuario", unique: true);
            CreateIndex("dbo.Usuarios", "AreaID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "AreaID" });
            DropIndex("dbo.Usuarios", new[] { "NombreUsuario" });
            DropIndex("dbo.Areas", new[] { "Nombre" });
            CreateIndex("dbo.Usuarios", "areaID");
        }
    }
}
