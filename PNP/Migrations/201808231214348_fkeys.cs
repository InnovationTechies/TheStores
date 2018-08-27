namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PnpEmployees",
                c => new
                    {
                        PnpEmpID = c.Int(nullable: false, identity: true),
                        PnpEmpName = c.String(unicode: false),
                        PnpEmpSurname = c.String(unicode: false),
                        PnpEmpEmail = c.String(unicode: false),
                        PnpPassword = c.String(unicode: false),
                        PnpEmpGender = c.String(unicode: false),
                        PnpDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.PnpEmpID);
            
            CreateTable(
                "dbo.PnpLocations",
                c => new
                    {
                        PnpLocationID = c.Int(nullable: false, identity: true),
                        PnpLocationName = c.String(unicode: false),
                        PnpLocationStreetAddress = c.String(unicode: false),
                        PnpLocationSuburbAddress = c.String(unicode: false),
                        PnpLocationCodeAddress = c.String(unicode: false),
                        PnpLocationCoordinates = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PnpLocationID);
            
            CreateTable(
                "dbo.PnpManagers",
                c => new
                    {
                        PnpManID = c.Int(nullable: false, identity: true),
                        PnpManName = c.String(unicode: false),
                        PnpManSurname = c.String(unicode: false),
                        PnpManEmail = c.String(unicode: false),
                        PnpManPassword = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.PnpManID);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        catagoryID = c.Int(nullable: false, identity: true),
                        CatagoryName = c.String(unicode: false),
                        CatagoryDesc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.catagoryID);

            CreateTable(
                "dbo.PnpProducts",
                c => new
                {
                    ProductID = c.Int(nullable: false, identity: true),
                    ProductName = c.String(unicode: false),
                    ProductPrice = c.Single(nullable: false),
                    ProductImage = c.String(unicode: false),
                    ProductDropPercent = c.Double(nullable: false),
                    ProductDesc = c.String(unicode: false),
                    ProductDateEndPromo = c.DateTime(nullable: false, precision: 0),
                    Catagory_catagoryID = c.Int(),
                })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCatagories", t => t.Catagory_catagoryID);
                //.Index(t => t.Catagory_catagoryID);

            CreateTable(
                "dbo.PnpSales",
                c => new
                {
                    PnpSalesID = c.Int(nullable: false, identity: true),
                    Employee_PnpEmpID = c.Int(),
                    Location_PnpLocationID = c.Int(),
                    Manager_PnpManID = c.Int(),
                    Products_ProductID = c.Int(),
                    Special_PnpSpecialID = c.Int(),
                })
                .PrimaryKey(t => t.PnpSalesID)
                .ForeignKey("dbo.PnpEmployees", t => t.Employee_PnpEmpID)
                .ForeignKey("dbo.PnpLocations", t => t.Location_PnpLocationID)
                .ForeignKey("dbo.PnpManagers", t => t.Manager_PnpManID)
                .ForeignKey("dbo.PnpProducts", t => t.Products_ProductID)
                .ForeignKey("dbo.PnpSpecials", t => t.Special_PnpSpecialID);
                //.Index(t => t.Employee_PnpEmpID)
                //.Index(t => t.Location_PnpLocationID)
                //.Index(t => t.Manager_PnpManID)
                //.Index(t => t.Products_ProductID)
                //.Index(t => t.Special_PnpSpecialID);
            
            CreateTable(
                "dbo.PnpSpecials",
                c => new
                    {
                        PnpSpecialID = c.Int(nullable: false, identity: true),
                        PnpSpecialName = c.String(unicode: false),
                        PnpSpecialDesc = c.String(unicode: false),
                        PnpStartDate = c.DateTime(nullable: false, precision: 0),
                        PnpEndDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.PnpSpecialID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PnpSales", "Special_PnpSpecialID", "dbo.PnpSpecials");
            DropForeignKey("dbo.PnpSales", "Products_ProductID", "dbo.PnpProducts");
            DropForeignKey("dbo.PnpSales", "Manager_PnpManID", "dbo.PnpManagers");
            DropForeignKey("dbo.PnpSales", "Location_PnpLocationID", "dbo.PnpLocations");
            DropForeignKey("dbo.PnpSales", "Employee_PnpEmpID", "dbo.PnpEmployees");
            DropForeignKey("dbo.PnpProducts", "Catagory_catagoryID", "dbo.ProductCatagories");
            DropIndex("dbo.PnpSales", new[] { "Special_PnpSpecialID" });
            DropIndex("dbo.PnpSales", new[] { "Products_ProductID" });
            DropIndex("dbo.PnpSales", new[] { "Manager_PnpManID" });
            DropIndex("dbo.PnpSales", new[] { "Location_PnpLocationID" });
            DropIndex("dbo.PnpSales", new[] { "Employee_PnpEmpID" });
            DropIndex("dbo.PnpProducts", new[] { "Catagory_catagoryID" });
            DropTable("dbo.PnpSpecials");
            DropTable("dbo.PnpSales");
            DropTable("dbo.PnpProducts");
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.PnpManagers");
            DropTable("dbo.PnpLocations");
            DropTable("dbo.PnpEmployees");
        }
    }
}
