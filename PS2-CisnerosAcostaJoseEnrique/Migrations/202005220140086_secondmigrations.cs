namespace PS2_CisnerosAcostaJoseEnrique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigrations : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Status", c => c.String());
        }
    }
}
