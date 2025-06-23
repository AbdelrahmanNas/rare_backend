using Microsoft.EntityFrameworkCore;
using RareDiseasesAPI.Models;

namespace RareDiseasesAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Disease> Diseases { get; set; }
        public DbSet<StaticPage> StaticPages { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; } // ✅ تمت الإضافة هنا

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Static Pages
            modelBuilder.Entity<StaticPage>().HasData(
                new StaticPage { Id = 1, Title = "Home", Content = "مرحباً بكم في موقع الأمراض النادرة." },
                new StaticPage { Id = 2, Title = "About Us", Content = "هذا الموقع يهدف إلى رفع التوعية حول الأمراض النادرة." },
                new StaticPage { Id = 3, Title = "Contact Us", Content = "للتواصل معنا يرجى إرسال بريد إلكتروني إلى example@email.com." }
            );
        }
    }
}
