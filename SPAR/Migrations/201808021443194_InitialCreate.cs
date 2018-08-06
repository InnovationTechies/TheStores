namespace SPAR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SparProducts",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        productImage = c.String(),
                        productDropPercent = c.Double(nullable: false),
                        productDescription = c.String(),
                        productDateEndPromo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.productID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SparProducts");
        }
    }
}
