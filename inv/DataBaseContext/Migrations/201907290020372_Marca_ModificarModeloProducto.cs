namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marca_ModificarModeloProducto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        MarcaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.MarcaID)
                .Index(t => t.Nombre, unique: true);
            
            AddColumn("dbo.Producto", "NumeroSerie", c => c.String());
            AddColumn("dbo.Producto", "marcaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "marcaID");
            AddForeignKey("dbo.Producto", "marcaID", "dbo.Marca", "MarcaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "marcaID", "dbo.Marca");
            DropIndex("dbo.Marca", new[] { "Nombre" });
            DropIndex("dbo.Producto", new[] { "marcaID" });
            DropColumn("dbo.Producto", "marcaID");
            DropColumn("dbo.Producto", "NumeroSerie");
            DropTable("dbo.Marca");
        }
    }
}
