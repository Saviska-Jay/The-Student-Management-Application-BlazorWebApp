using Microsoft.EntityFrameworkCore;
using TheStudentManagementApplication.Models;

namespace TheStudentManagementApplication.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;

        public StudentService(StudentDbContext context)
        {
            _context = context;
        }

        public async Task<List<TheStudent>> GetAllStudents()
        {
            return await _context.StudentInfoTable.ToListAsync();
        }

        public async Task<TheStudent> GetStudentById(int id)
        {
            var student = await _context.StudentInfoTable.FindAsync(id);
            if (student == null)
            {
                throw new Exception("Student Not Found !");
            }
            return student;
        }

        public async Task AddStudent(TheStudent student)
        {
            _context.StudentInfoTable.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStudent(TheStudent student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudent(int id)
        {
            var student = await _context.StudentInfoTable.FindAsync(id);
            if (student != null)
            {
                _context.StudentInfoTable.Remove(student);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Student Not Found !");
            }

        }
        public async Task <TheStudent> GetStudentByIndexNumber(int indexNumber)
        {
            var student = await _context.StudentInfoTable.FirstOrDefaultAsync(s => s.IndexNumber == indexNumber);
            if (student == null)
            {
                throw new Exception("Student with this Index Number Not Found!");
            }
            return student;
        }

    }
}
