namespace SPAR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SparProducts",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        productName = c.String(unicode: false),
                        productImage = c.String(unicode: false),
                        productDropPercent = c.Double(nullable: false),
                        productDescription = c.String(unicode: false),
                        productDateEndPromo = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.productID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SparProducts");
        }
    }
}
