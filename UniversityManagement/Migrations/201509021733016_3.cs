namespace UniversityManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentCode", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 32));
            CreateIndex("dbo.Departments", "DepartmentCode", unique: true);
            CreateIndex("dbo.Departments", "DepartmentName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            DropIndex("dbo.Departments", new[] { "DepartmentCode" });
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentCode", c => c.String(nullable: false));
        }
    }
}
