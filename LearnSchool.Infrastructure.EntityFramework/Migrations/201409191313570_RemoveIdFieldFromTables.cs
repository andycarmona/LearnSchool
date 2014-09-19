namespace LearnSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveIdFieldFromTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PhraseDictionary", "DictionaryId");
            DropColumn("dbo.Phrases", "PhraseId");
            DropColumn("dbo.Words", "WordId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Words", "WordId", c => c.Int(nullable: false));
            AddColumn("dbo.Phrases", "PhraseId", c => c.Int(nullable: false));
            AddColumn("dbo.PhraseDictionary", "DictionaryId", c => c.Int(nullable: false));
        }
    }
}
