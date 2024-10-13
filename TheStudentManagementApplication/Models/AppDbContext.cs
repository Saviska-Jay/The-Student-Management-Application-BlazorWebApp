using Microsoft.EntityFrameworkCore;

namespace TheStudentManagementApplication.Models
{
    //This is for connect with the MS SQl table.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) 
        {
        }
        public DbSet<TheStudent> StudentInfoTable { get; set; }

        public DbSet<TheUserAccount> UserAccountTable { get; set; }
    }
}
