namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thesalesmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PnpSales",
                c => new
                    {
                        pnpSalesID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.pnpSalesID);
            
            AddColumn("dbo.PnpEmployees", "PnpSales_pnpSalesID", c => c.Int());
            AddColumn("dbo.PnpLocations", "PnpSales_pnpSalesID", c => c.Int());
            AddColumn("dbo.PnpManagers", "PnpSales_pnpSalesID", c => c.Int());
            AddColumn("dbo.Products", "PnpSales_pnpSalesID", c => c.Int());
            AddColumn("dbo.PnpSpecials", "PnpSales_pnpSalesID", c => c.Int());
            CreateIndex("dbo.PnpEmployees", "PnpSales_pnpSalesID");
            CreateIndex("dbo.PnpLocations", "PnpSales_pnpSalesID");
            CreateIndex("dbo.PnpManagers", "PnpSales_pnpSalesID");
            CreateIndex("dbo.Products", "PnpSales_pnpSalesID");
            CreateIndex("dbo.PnpSpecials", "PnpSales_pnpSalesID");
            AddForeignKey("dbo.PnpEmployees", "PnpSales_pnpSalesID", "dbo.PnpSales", "pnpSalesID");
            AddForeignKey("dbo.PnpLocations", "PnpSales_pnpSalesID", "dbo.PnpSales", "pnpSalesID");
            AddForeignKey("dbo.PnpManagers", "PnpSales_pnpSalesID", "dbo.PnpSales", "pnpSalesID");
            AddForeignKey("dbo.Products", "PnpSales_pnpSalesID", "dbo.PnpSales", "pnpSalesID");
            AddForeignKey("dbo.PnpSpecials", "PnpSales_pnpSalesID", "dbo.PnpSales", "pnpSalesID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PnpSpecials", "PnpSales_pnpSalesID", "dbo.PnpSales");
            DropForeignKey("dbo.Products", "PnpSales_pnpSalesID", "dbo.PnpSales");
            DropForeignKey("dbo.PnpManagers", "PnpSales_pnpSalesID", "dbo.PnpSales");
            DropForeignKey("dbo.PnpLocations", "PnpSales_pnpSalesID", "dbo.PnpSales");
            DropForeignKey("dbo.PnpEmployees", "PnpSales_pnpSalesID", "dbo.PnpSales");
            DropIndex("dbo.PnpSpecials", new[] { "PnpSales_pnpSalesID" });
            DropIndex("dbo.Products", new[] { "PnpSales_pnpSalesID" });
            DropIndex("dbo.PnpManagers", new[] { "PnpSales_pnpSalesID" });
            DropIndex("dbo.PnpLocations", new[] { "PnpSales_pnpSalesID" });
            DropIndex("dbo.PnpEmployees", new[] { "PnpSales_pnpSalesID" });
            DropColumn("dbo.PnpSpecials", "PnpSales_pnpSalesID");
            DropColumn("dbo.Products", "PnpSales_pnpSalesID");
            DropColumn("dbo.PnpManagers", "PnpSales_pnpSalesID");
            DropColumn("dbo.PnpLocations", "PnpSales_pnpSalesID");
            DropColumn("dbo.PnpEmployees", "PnpSales_pnpSalesID");
            DropTable("dbo.PnpSales");
        }
    }
}
