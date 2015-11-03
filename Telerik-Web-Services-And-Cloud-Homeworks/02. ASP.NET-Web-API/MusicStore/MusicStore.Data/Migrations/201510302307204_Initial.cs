namespace MusicStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Year = c.DateTime(),
                        ProducerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producers", t => t.ProducerId, cascadeDelete: true)
                .Index(t => t.ProducerId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfBirth = c.DateTime(),
                        CountryId = c.Int(nullable: false),
                        Producer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Producers", t => t.Producer_Id)
                .Index(t => t.CountryId)
                .Index(t => t.Producer_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        GenreId = c.Int(nullable: false),
                        ArtistId = c.Int(nullable: false),
                        AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Artists", t => t.ArtistId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId)
                .Index(t => t.ArtistId)
                .Index(t => t.AlbumId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArtistAlbums",
                c => new
                    {
                        Artist_Id = c.Int(nullable: false),
                        Album_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Artist_Id, t.Album_Id })
                .ForeignKey("dbo.Artists", t => t.Artist_Id, cascadeDelete: true)
                .ForeignKey("dbo.Albums", t => t.Album_Id, cascadeDelete: true)
                .Index(t => t.Artist_Id)
                .Index(t => t.Album_Id);          
        }
              
        public override void Down()
        {
            this.DropForeignKey("dbo.Songs", "GenreId", "dbo.Genres");
            this.DropForeignKey("dbo.Songs", "ArtistId", "dbo.Artists");
            this.DropForeignKey("dbo.Songs", "AlbumId", "dbo.Albums");
            this.DropForeignKey("dbo.Albums", "ProducerId", "dbo.Producers");
            this.DropForeignKey("dbo.Artists", "Producer_Id", "dbo.Producers");
            this.DropForeignKey("dbo.Artists", "CountryId", "dbo.Countries");
            this.DropForeignKey("dbo.ArtistAlbums", "Album_Id", "dbo.Albums");
            this.DropForeignKey("dbo.ArtistAlbums", "Artist_Id", "dbo.Artists");
            this.DropIndex("dbo.ArtistAlbums", new[] { "Album_Id" });
            this.DropIndex("dbo.ArtistAlbums", new[] { "Artist_Id" });
            this.DropIndex("dbo.Songs", new[] { "AlbumId" });
            this.DropIndex("dbo.Songs", new[] { "ArtistId" });
            this.DropIndex("dbo.Songs", new[] { "GenreId" });
            this.DropIndex("dbo.Artists", new[] { "Producer_Id" });
            this.DropIndex("dbo.Artists", new[] { "CountryId" });
            this.DropIndex("dbo.Albums", new[] { "ProducerId" });
            this.DropTable("dbo.ArtistAlbums");
            this.DropTable("dbo.Genres");
            this.DropTable("dbo.Songs");
            this.DropTable("dbo.Producers");
            this.DropTable("dbo.Countries");
            this.DropTable("dbo.Artists");
            this.DropTable("dbo.Albums");
        }
    }
}
