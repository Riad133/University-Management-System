namespace UniversityManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 32),
                        Credit = c.Double(nullable: false),
                        Name = c.String(maxLength: 32),
                        Description = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "Name" });
            DropIndex("dbo.Courses", new[] { "Code" });
            DropTable("dbo.Courses");
        }
    }
}
