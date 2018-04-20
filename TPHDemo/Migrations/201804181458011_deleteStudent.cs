namespace TPHDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteStudent : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
