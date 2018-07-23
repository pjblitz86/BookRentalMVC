namespace PJBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModelTestChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Boolean());
            AlterColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "Disable", c => c.Boolean(nullable: false));
        }
    }
}
