namespace Pos.Infras.Data.EFRepositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFatherName : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Employees", "FatherName", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.Employees", "FatherName");
        }
    }
}
