namespace HRProgramWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateOfEmpolyementNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "DateOfEmpolyement", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DateOfEmpolyement", c => c.DateTime(nullable: false));
        }
    }
}
