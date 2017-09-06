namespace TFD_AndreySchemel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TFD_Andrey1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        numeroTelefone = c.Int(nullable: false),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
