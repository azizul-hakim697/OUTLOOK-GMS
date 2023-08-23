namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saldb3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "Bonus", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Salaries", "Bonues");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Salaries", "Bonues", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Salaries", "Bonus");
        }
    }
}
