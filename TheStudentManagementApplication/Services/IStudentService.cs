using TheStudentManagementApplication.Models;

namespace TheStudentManagementApplication.Services
{
    public interface IStudentService
    {
        Task<List<TheStudent>> GetAllStudents();
        Task<TheStudent> GetStudentById(int id);
        Task AddStudent(TheStudent student);
        Task UpdateStudent(TheStudent student);
        Task DeleteStudent(int id);
        Task<TheStudent> GetStudentByIndexNumber(int indexNumber);
    }
}
