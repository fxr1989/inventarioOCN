namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Salida_CantidadTotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salida", "CantidadTotal", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salida", "CantidadTotal");
        }
    }
}
