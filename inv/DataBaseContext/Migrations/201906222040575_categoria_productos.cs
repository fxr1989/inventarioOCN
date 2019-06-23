namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoria_productos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.CategoriaID)
                .Index(t => t.Nombre, unique: true);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 50),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Descripcion = c.String(maxLength: 300),
                        CodigoBarra = c.String(),
                        Modelo = c.String(maxLength: 100),
                        categoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoID)
                .ForeignKey("dbo.Categorias", t => t.categoriaID, cascadeDelete: true)
                .Index(t => t.Codigo, unique: true)
                .Index(t => t.categoriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "categoriaID", "dbo.Categorias");
            DropIndex("dbo.Productos", new[] { "categoriaID" });
            DropIndex("dbo.Productos", new[] { "Codigo" });
            DropIndex("dbo.Categorias", new[] { "Nombre" });
            DropTable("dbo.Productos");
            DropTable("dbo.Categorias");
        }
    }
}
