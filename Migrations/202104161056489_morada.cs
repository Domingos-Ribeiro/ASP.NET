namespace EquipasMembros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class morada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Morada", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Morada");
        }
    }
}
