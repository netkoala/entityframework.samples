namespace EntityFrameworkSamples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Year = c.Int(nullable: false),
                        ExteriorColor = c.String(),
                        InteriorColor = c.String(),
                        Name = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CellPhones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        ScreenSize = c.Double(nullable: false),
                        StorageCapacity = c.Int(nullable: false),
                        Name = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clothings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Style = c.String(),
                        Color = c.String(),
                        Material = c.String(),
                        Name = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clothings");
            DropTable("dbo.CellPhones");
            DropTable("dbo.Cars");
        }
    }
}
