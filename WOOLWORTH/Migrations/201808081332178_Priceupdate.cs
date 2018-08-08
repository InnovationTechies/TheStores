namespace WOOLWORTH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Priceupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WoolworthProducts", "ProductPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WoolworthProducts", "ProductPrice");
        }
    }
}
