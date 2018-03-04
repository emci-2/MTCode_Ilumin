namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email", c => c.String());
            DropColumn("dbo.Person", "Email_EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Email_EmailAddress", c => c.String());
            DropColumn("dbo.Person", "Email");
        }
    }
}
