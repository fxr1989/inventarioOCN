namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipoAcceso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RolAcceso", "Agregar", c => c.Boolean(nullable: false));
            AddColumn("dbo.RolAcceso", "Editar", c => c.Boolean(nullable: false));
            AddColumn("dbo.RolAcceso", "Eliminar", c => c.Boolean(nullable: false));
            AddColumn("dbo.RolAcceso", "Ver", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RolAcceso", "Ver");
            DropColumn("dbo.RolAcceso", "Eliminar");
            DropColumn("dbo.RolAcceso", "Editar");
            DropColumn("dbo.RolAcceso", "Agregar");
        }
    }
}
