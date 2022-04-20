namespace BookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTheTypeAvaibility : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Avaibility", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Avaibility", c => c.String(nullable: false));
        }
    }
}
