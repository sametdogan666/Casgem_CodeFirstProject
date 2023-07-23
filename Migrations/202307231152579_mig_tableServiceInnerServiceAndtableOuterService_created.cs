namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_tableServiceInnerServiceAndtableOuterService_created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceInnerServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IconClass = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceOuterServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceOuterServices");
            DropTable("dbo.ServiceInnerServices");
        }
    }
}
