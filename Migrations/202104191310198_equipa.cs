namespace EquipasMembros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeEquipa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Clientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Telefone = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Equipas");
        }
    }
}
