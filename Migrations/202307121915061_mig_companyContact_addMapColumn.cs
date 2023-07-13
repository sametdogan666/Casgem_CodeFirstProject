namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_companyContact_addMapColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyContacts", "MapLocation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CompanyContacts", "MapLocation");
        }
    }
}
