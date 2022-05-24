namespace Odev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        bolumID = c.Int(nullable: false, identity: true),
                        bolumAd = c.String(),
                        fakulteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bolumID)
                .ForeignKey("dbo.Fakultes", t => t.fakulteID, cascadeDelete: true)
                .Index(t => t.fakulteID);
            
            CreateTable(
                "dbo.Fakultes",
                c => new
                    {
                        fakulteID = c.Int(nullable: false, identity: true),
                        fakulteAd = c.String(),
                    })
                .PrimaryKey(t => t.fakulteID);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        ogrenciID = c.Int(nullable: false, identity: true),
                        ogrenciAd = c.String(),
                        ogrenciSoyad = c.String(),
                        bolumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ogrenciID)
                .ForeignKey("dbo.Bolums", t => t.bolumID, cascadeDelete: true)
                .Index(t => t.bolumID);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ogrenciID = c.Int(nullable: false),
                        dersID = c.Int(nullable: false),
                        yil = c.DateTime(nullable: false),
                        yariyil = c.Int(nullable: false),
                        vize = c.Int(nullable: false),
                        final = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ders", t => t.dersID, cascadeDelete: true)
                .ForeignKey("dbo.Ogrencis", t => t.ogrenciID, cascadeDelete: true)
                .Index(t => t.ogrenciID)
                .Index(t => t.dersID);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dersAd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciDers", "ogrenciID", "dbo.Ogrencis");
            DropForeignKey("dbo.OgrenciDers", "dersID", "dbo.Ders");
            DropForeignKey("dbo.Ogrencis", "bolumID", "dbo.Bolums");
            DropForeignKey("dbo.Bolums", "fakulteID", "dbo.Fakultes");
            DropIndex("dbo.OgrenciDers", new[] { "dersID" });
            DropIndex("dbo.OgrenciDers", new[] { "ogrenciID" });
            DropIndex("dbo.Ogrencis", new[] { "bolumID" });
            DropIndex("dbo.Bolums", new[] { "fakulteID" });
            DropTable("dbo.Ders");
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Fakultes");
            DropTable("dbo.Bolums");
        }
    }
}
