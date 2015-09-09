namespace KaJo.WebAPI.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "LastUpdated", c => c.DateTime());
            AlterColumn("dbo.Books", "LastUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "LastUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Authors", "LastUpdated", c => c.DateTime(nullable: false));
        }
    }
}
