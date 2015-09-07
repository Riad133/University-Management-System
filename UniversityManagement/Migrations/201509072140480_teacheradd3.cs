namespace UniversityManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacheradd3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Designation", c => c.String(nullable: false));
            DropColumn("dbo.Teachers", "DesignationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "DesignationId", c => c.Int(nullable: false));
            DropColumn("dbo.Teachers", "Designation");
        }
    }
}
