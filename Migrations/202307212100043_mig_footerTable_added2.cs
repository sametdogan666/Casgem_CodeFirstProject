namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_footerTable_added2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GithubUrl = c.String(),
                        InstagramUrl = c.String(),
                        LinkedinUrl = c.String(),
                        Category1 = c.String(),
                        Category2 = c.String(),
                        Category3 = c.String(),
                        Category4 = c.String(),
                        Category5 = c.String(),
                        ImageUrl1 = c.String(),
                        ImageUrl2 = c.String(),
                        ImageUrl3 = c.String(),
                        ImageUrl4 = c.String(),
                        ImageUrl5 = c.String(),
                        ImageUrl6 = c.String(),
                        Travel1 = c.String(),
                        Travel2 = c.String(),
                        Travel3 = c.String(),
                        Travel4 = c.String(),
                        Travel5 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Footers");
        }
    }
}
