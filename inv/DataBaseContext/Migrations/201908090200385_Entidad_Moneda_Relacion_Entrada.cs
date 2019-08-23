namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Entidad_Moneda_Relacion_Entrada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moneda",
                c => new
                    {
                        MonedaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Simbolo = c.String(),
                    })
                .PrimaryKey(t => t.MonedaID);
            
            AddColumn("dbo.EntradaLinea", "monedaID", c => c.Int(nullable: false));
            CreateIndex("dbo.EntradaLinea", "monedaID");
            AddForeignKey("dbo.EntradaLinea", "monedaID", "dbo.Moneda", "MonedaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EntradaLinea", "monedaID", "dbo.Moneda");
            DropIndex("dbo.EntradaLinea", new[] { "monedaID" });
            DropColumn("dbo.EntradaLinea", "monedaID");
            DropTable("dbo.Moneda");
        }
    }
}
