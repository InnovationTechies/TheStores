namespace WOOLWORTH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WoolworthProducts",
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
            DropTable("dbo.WoolworthProducts");
        }
    }
}
