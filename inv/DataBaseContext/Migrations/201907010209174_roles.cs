namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        RolID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.RolID)
                .Index(t => t.Nombre, unique: true);
            
            CreateTable(
                "dbo.RolAcceso",
                c => new
                    {
                        RolAccesoID = c.Int(nullable: false, identity: true),
                        rolID = c.Int(nullable: false),
                        permisoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RolAccesoID)
                .ForeignKey("dbo.Permiso", t => t.permisoID, cascadeDelete: true)
                .ForeignKey("dbo.Rol", t => t.rolID, cascadeDelete: true)
                .Index(t => t.rolID)
                .Index(t => t.permisoID);
            
            CreateTable(
                "dbo.Permiso",
                c => new
                    {
                        PermisoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.PermisoID)
                .Index(t => t.Nombre, unique: true);
            
            AddColumn("dbo.Usuario", "rolID", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuario", "rolID");
            AddForeignKey("dbo.Usuario", "rolID", "dbo.Rol", "RolID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "rolID", "dbo.Rol");
            DropForeignKey("dbo.RolAcceso", "rolID", "dbo.Rol");
            DropForeignKey("dbo.RolAcceso", "permisoID", "dbo.Permiso");
            DropIndex("dbo.Permiso", new[] { "Nombre" });
            DropIndex("dbo.RolAcceso", new[] { "permisoID" });
            DropIndex("dbo.RolAcceso", new[] { "rolID" });
            DropIndex("dbo.Rol", new[] { "Nombre" });
            DropIndex("dbo.Usuario", new[] { "rolID" });
            DropColumn("dbo.Usuario", "rolID");
            DropTable("dbo.Permiso");
            DropTable("dbo.RolAcceso");
            DropTable("dbo.Rol");
        }
    }
}
