namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinMaxOnGPA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email_EmailAddress", c => c.String());
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
            AddColumn("dbo.Person", "GPA", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "GPA");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Email_EmailAddress");
        }
    }
}