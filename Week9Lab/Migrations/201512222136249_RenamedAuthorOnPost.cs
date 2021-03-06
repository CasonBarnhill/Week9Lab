namespace Week9Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedAuthorOnPost : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "Author_Id");
            RenameIndex(table: "dbo.Posts", name: "IX_User_Id", newName: "IX_Author_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Posts", name: "IX_Author_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Posts", name: "Author_Id", newName: "User_Id");
        }
    }
}
