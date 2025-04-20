using Microsoft.EntityFrameworkCore;
using Student_Portal.Web.Models.Entities;

namespace Student_Portal.Web.Data
{
    public class ApplicationDbContext : DbContext      //DbContext: serves as the central class for interacting with the database
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
       
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
