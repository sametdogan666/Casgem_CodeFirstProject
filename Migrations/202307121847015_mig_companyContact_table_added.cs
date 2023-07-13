namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_companyContact_table_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyContacts");
        }
    }
}
