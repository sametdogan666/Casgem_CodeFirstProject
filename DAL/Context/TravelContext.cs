using System.Data.Entity;
using Casgem_CodeFirstProject.DAL.Entities;

namespace Casgem_CodeFirstProject.DAL.Context
{
    public class TravelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CompanyContact> CompanyContacts { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Explore> Explores { get; set; }
        public DbSet<AboutFirstBlog> AboutFirstBlogs { get; set; }
        public DbSet<AboutSecondBlog> AboutSecondBlogs { get; set; }
        public DbSet<AboutThirdBlog> AboutThirdBlogs { get; set; }

        

    }
}