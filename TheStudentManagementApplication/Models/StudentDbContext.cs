using Microsoft.EntityFrameworkCore;

namespace TheStudentManagementApplication.Models
{
    //This is for connect with the MS SQl table.
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options) : base(options) 
        {
        }
        public DbSet<TheStudent> StudentInfoTable { get; set; }
    }
}
