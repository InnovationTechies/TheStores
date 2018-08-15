namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thenewmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PnpEmployees",
                c => new
                    {
                        pnpEmpID = c.Int(nullable: false, identity: true),
                        pnpEmpName = c.String(unicode: false),
                        pnpEmpSurname = c.String(unicode: false),
                        pnpEmpEmail = c.String(unicode: false),
                        pnpPassword = c.String(unicode: false),
                        pnpEmpGender = c.String(unicode: false),
                        pnpDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.pnpEmpID);
            
            CreateTable(
                "dbo.PnpLocations",
                c => new
                    {
                        pnpLocationID = c.Int(nullable: false, identity: true),
                        pnpLocationName = c.String(unicode: false),
                        pnpLocationStreetAddress = c.String(unicode: false),
                        pnpLocationSuburbAddress = c.String(unicode: false),
                        pnpLocationCodeAddress = c.String(unicode: false),
                        pnpLocationCoordinates = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.pnpLocationID);
            
            CreateTable(
                "dbo.PnpManagers",
                c => new
                    {
                        pnpManID = c.Int(nullable: false, identity: true),
                        pnpManName = c.String(unicode: false),
                        pnpManSurname = c.String(unicode: false),
                        pnpManEmail = c.String(unicode: false),
                        pnpManPassword = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.pnpManID);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        catagoryID = c.Int(nullable: false, identity: true),
                        catagoryName = c.String(unicode: false),
                        catagoryDesc = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.catagoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        productName = c.String(unicode: false),
                        productPrice = c.Single(nullable: false),
                        productImage = c.String(unicode: false),
                        productDropPercent = c.Double(nullable: false),
                        productDesc = c.String(unicode: false),
                        productDateEndPromo = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.productID);
            
            CreateTable(
                "dbo.PnpSpecials",
                c => new
                    {
                        pnpSpecialID = c.Int(nullable: false, identity: true),
                        pnpSpecialName = c.String(unicode: false),
                        pnpSpecialDesc = c.String(unicode: false),
                        pnpStartDate = c.DateTime(nullable: false, precision: 0),
                        pnpEndDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.pnpSpecialID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PnpSpecials");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.PnpManagers");
            DropTable("dbo.PnpLocations");
            DropTable("dbo.PnpEmployees");
        }
    }
}
