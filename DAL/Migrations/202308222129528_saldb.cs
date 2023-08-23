namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saldb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bonues = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Allowance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Salaries");
        }
    }
}
