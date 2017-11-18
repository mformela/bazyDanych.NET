namespace BazyDanych.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanieDatyModyfikacji : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestDBmodels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prop = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestDBmodels");
        }
    }
}
