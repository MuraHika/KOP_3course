namespace DataBaseImplementDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Postavs", "DateLastPost", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Postavs", "DateLastPost", c => c.DateTime(nullable: false));
        }
    }
}
