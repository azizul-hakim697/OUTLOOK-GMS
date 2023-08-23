namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RawMaterials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        supplier = c.String(nullable: false),
                        quantity = c.Int(nullable: false),
                        percost = c.Int(nullable: false),
                        totalcost = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RawMaterials");
        }
    }
}
