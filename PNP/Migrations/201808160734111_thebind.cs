namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thebind : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PnpSales",
                c => new
                    {
                        PnpSalesID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PnpSalesID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PnpSales");
        }
    }
}
