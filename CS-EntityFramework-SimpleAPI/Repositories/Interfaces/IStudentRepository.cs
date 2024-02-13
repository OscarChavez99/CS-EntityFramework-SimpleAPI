using CS_EntityFramework_SimpleAPI.Models;

namespace CS_EntityFramework_SimpleAPI.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        Task<ApiResponse> GetAllStudents();
        Task<ApiResponse> GetStudentById(int id);
        Task<ApiResponse> GetStudentsFilterByName(string name);
        Task<ApiResponse> Post(Student student);
        Task<ApiResponse> Put(Student student);
        Task<ApiResponse> Delete(int id);
    }
}
