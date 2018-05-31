namespace BlogSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserFullName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "FullName", c => c.String(maxLength: 100));
        }
    }
}
