namespace EquipasMembros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeMembro = c.String(),
                        EquipaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipas", t => t.EquipaId, cascadeDelete: true)
                .Index(t => t.EquipaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Membroes", "EquipaId", "dbo.Equipas");
            DropIndex("dbo.Membroes", new[] { "EquipaId" });
            DropTable("dbo.Membroes");
        }
    }
}
