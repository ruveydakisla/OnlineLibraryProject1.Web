using Microsoft.EntityFrameworkCore;

namespace OnlineLibraryProject.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }




    }
}
