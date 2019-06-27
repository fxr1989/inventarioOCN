namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modelo_Ubicacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ubicaciones",
                c => new
                    {
                        UbicacionID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.UbicacionID)
                .Index(t => t.Nombre, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ubicaciones", new[] { "Nombre" });
            DropTable("dbo.Ubicaciones");
        }
    }
}
