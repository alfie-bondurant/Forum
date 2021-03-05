namespace Forum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_DB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ocenas", newName: "Ocena");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Ocena", newName: "Ocenas");
        }
    }
}
