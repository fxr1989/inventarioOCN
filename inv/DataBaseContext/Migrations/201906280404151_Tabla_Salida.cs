namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tabla_Salida : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salida",
                c => new
                    {
                        SalidaID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        usuarioID = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalidaID)
                .ForeignKey("dbo.Usuario", t => t.usuarioID, cascadeDelete: true)
                .Index(t => t.usuarioID);
            
            CreateTable(
                "dbo.SalidaLinea",
                c => new
                    {
                        SalidaLineaID = c.Int(nullable: false, identity: true),
                        salidaID = c.Int(nullable: false),
                        productoID = c.Int(nullable: false),
                        ubicacionID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Observacion = c.String(maxLength: 300),
                        FechaIngreso = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalidaLineaID)
                .ForeignKey("dbo.Producto", t => t.productoID, cascadeDelete: true)
                .ForeignKey("dbo.Salida", t => t.salidaID, cascadeDelete: true)
                .ForeignKey("dbo.Ubicacion", t => t.ubicacionID, cascadeDelete: true)
                .Index(t => t.salidaID)
                .Index(t => t.productoID)
                .Index(t => t.ubicacionID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salida", "usuarioID", "dbo.Usuario");
            DropForeignKey("dbo.SalidaLinea", "ubicacionID", "dbo.Ubicacion");
            DropForeignKey("dbo.SalidaLinea", "salidaID", "dbo.Salida");
            DropForeignKey("dbo.SalidaLinea", "productoID", "dbo.Producto");
            DropIndex("dbo.SalidaLinea", new[] { "ubicacionID" });
            DropIndex("dbo.SalidaLinea", new[] { "productoID" });
            DropIndex("dbo.SalidaLinea", new[] { "salidaID" });
            DropIndex("dbo.Salida", new[] { "usuarioID" });
            DropTable("dbo.SalidaLinea");
            DropTable("dbo.Salida");
        }
    }
}
