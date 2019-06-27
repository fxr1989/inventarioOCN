namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableInventario : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Areas", newName: "Area");
            RenameTable(name: "dbo.Usuarios", newName: "Usuario");
            RenameTable(name: "dbo.Categorias", newName: "Categoria");
            RenameTable(name: "dbo.Productos", newName: "Producto");
            RenameTable(name: "dbo.Entradas", newName: "Entrada");
            RenameTable(name: "dbo.EntradasLineas", newName: "EntradaLinea");
            RenameTable(name: "dbo.Ubicaciones", newName: "Ubicacion");
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        productoID = c.Int(nullable: false),
                        ubicacionID = c.Int(nullable: false),
                        InventarioID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.productoID, t.ubicacionID })
                .ForeignKey("dbo.Producto", t => t.productoID, cascadeDelete: true)
                .ForeignKey("dbo.Ubicacion", t => t.ubicacionID, cascadeDelete: true)
                .Index(t => t.productoID)
                .Index(t => t.ubicacionID);
            
            AddColumn("dbo.EntradaLinea", "Observacion", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventario", "ubicacionID", "dbo.Ubicacion");
            DropForeignKey("dbo.Inventario", "productoID", "dbo.Producto");
            DropIndex("dbo.Inventario", new[] { "ubicacionID" });
            DropIndex("dbo.Inventario", new[] { "productoID" });
            DropColumn("dbo.EntradaLinea", "Observacion");
            DropTable("dbo.Inventario");
            RenameTable(name: "dbo.Ubicacion", newName: "Ubicaciones");
            RenameTable(name: "dbo.EntradaLinea", newName: "EntradasLineas");
            RenameTable(name: "dbo.Entrada", newName: "Entradas");
            RenameTable(name: "dbo.Producto", newName: "Productos");
            RenameTable(name: "dbo.Categoria", newName: "Categorias");
            RenameTable(name: "dbo.Usuario", newName: "Usuarios");
            RenameTable(name: "dbo.Area", newName: "Areas");
        }
    }
}
