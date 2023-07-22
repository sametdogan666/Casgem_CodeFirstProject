namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_exploreTable_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Explores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SmallTitle = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Explores");
        }
    }
}
