namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entrada_modelo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entradas",
                c => new
                    {
                        EntradaID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        usuarioID = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDonaciones = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntradaID)
                .ForeignKey("dbo.Usuarios", t => t.usuarioID, cascadeDelete: true)
                .Index(t => t.usuarioID);
            
            CreateTable(
                "dbo.EntradasLineas",
                c => new
                    {
                        EntradaLineaID = c.Int(nullable: false, identity: true),
                        entradaID = c.Int(nullable: false),
                        productoID = c.Int(nullable: false),
                        ubicacionID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Donacion = c.Boolean(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EntradaLineaID)
                .ForeignKey("dbo.Entradas", t => t.entradaID, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.productoID, cascadeDelete: true)
                .ForeignKey("dbo.Ubicaciones", t => t.ubicacionID, cascadeDelete: true)
                .Index(t => t.entradaID)
                .Index(t => t.productoID)
                .Index(t => t.ubicacionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entradas", "usuarioID", "dbo.Usuarios");
            DropForeignKey("dbo.EntradasLineas", "ubicacionID", "dbo.Ubicaciones");
            DropForeignKey("dbo.EntradasLineas", "productoID", "dbo.Productos");
            DropForeignKey("dbo.EntradasLineas", "entradaID", "dbo.Entradas");
            DropIndex("dbo.EntradasLineas", new[] { "ubicacionID" });
            DropIndex("dbo.EntradasLineas", new[] { "productoID" });
            DropIndex("dbo.EntradasLineas", new[] { "entradaID" });
            DropIndex("dbo.Entradas", new[] { "usuarioID" });
            DropTable("dbo.EntradasLineas");
            DropTable("dbo.Entradas");
        }
    }
}
