namespace EFF_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_migration_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Batches", "batchName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Batches", "batchName");
        }
    }
}
