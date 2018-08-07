namespace PNP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thefinalpnpdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        productName = c.String(unicode: false),
                        productImage = c.String(unicode: false),
                        productDropPercent = c.Double(nullable: false),
                        productDesc = c.String(unicode: false),
                        productDateEndPromo = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.productID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
