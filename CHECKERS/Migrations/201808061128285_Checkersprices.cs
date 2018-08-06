namespace CHECKERS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Checkersprices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "productPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "productPrice");
        }
    }
}
