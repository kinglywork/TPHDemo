namespace TPHDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotMappAnimalType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Animals", "Type", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Animals", "Type", c => c.String(maxLength: 100));
        }
    }
}
