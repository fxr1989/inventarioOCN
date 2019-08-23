namespace DataBaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formularioPermiso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Permiso", "Formulario", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Permiso", "Formulario");
        }
    }
}
