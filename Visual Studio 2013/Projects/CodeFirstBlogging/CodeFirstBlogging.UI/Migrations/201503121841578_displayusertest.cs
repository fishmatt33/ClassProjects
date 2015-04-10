namespace CodeFirstBlogging.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class displayusertest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DisplayName", c => c.String(maxLength: 23));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DisplayName", c => c.String());
        }
    }
}
