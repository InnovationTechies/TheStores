namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thepricemove : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "productPrice", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "productPrice");
        }
    }
}
