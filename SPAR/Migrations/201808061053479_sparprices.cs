namespace SPAR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sparprices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SparProducts", "productPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SparProducts", "productPrice");
        }
    }
}
