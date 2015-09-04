namespace UniversityManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "DesignationId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "DesignationId");
        }
    }
}
