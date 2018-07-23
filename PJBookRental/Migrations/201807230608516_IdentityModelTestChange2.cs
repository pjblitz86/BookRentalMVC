namespace PJBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModelTestChange2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Boolean(nullable: false));
            AlterColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int());
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Boolean());
        }
    }
}
