namespace PJBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookViewModelProps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookRents", "RentalPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookRents", "RentalPrice", c => c.Double());
        }
    }
}
