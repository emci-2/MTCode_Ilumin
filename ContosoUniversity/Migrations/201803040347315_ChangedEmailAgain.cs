namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedEmailAgain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email", c => c.String());
            DropColumn("dbo.Person", "Email_Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Email_Email", c => c.String());
            DropColumn("dbo.Person", "Email");
        }
    }
}
