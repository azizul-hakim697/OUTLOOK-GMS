namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saldb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "Net", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salaries", "Net");
        }
    }
}
