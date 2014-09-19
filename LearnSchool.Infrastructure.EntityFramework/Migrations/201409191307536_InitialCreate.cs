namespace LearnSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhraseDictionary",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DictionaryId = c.Int(nullable: false),
                        Author = c.String(),
                        DictionaryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phrases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhraseId = c.Int(nullable: false),
                        AssignedDictionaryId = c.Int(nullable: false),
                        PhraseText = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhraseDictionary", t => t.AssignedDictionaryId, cascadeDelete: true)
                .Index(t => t.AssignedDictionaryId);
            
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WordId = c.Int(nullable: false),
                        WordName = c.String(),
                        Image = c.String(),
                        SoundFile = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        AssignedPhraseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phrases", t => t.AssignedPhraseId, cascadeDelete: true)
                .Index(t => t.AssignedPhraseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Words", "AssignedPhraseId", "dbo.Phrases");
            DropForeignKey("dbo.Phrases", "AssignedDictionaryId", "dbo.PhraseDictionary");
            DropIndex("dbo.Words", new[] { "AssignedPhraseId" });
            DropIndex("dbo.Phrases", new[] { "AssignedDictionaryId" });
            DropTable("dbo.Words");
            DropTable("dbo.Phrases");
            DropTable("dbo.PhraseDictionary");
        }
    }
}
