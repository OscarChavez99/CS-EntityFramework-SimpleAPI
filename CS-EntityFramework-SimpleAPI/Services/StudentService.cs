using CS_EntityFramework_SimpleAPI.Models;
using CS_EntityFramework_SimpleAPI.Repositories.Interfaces;
using CS_EntityFramework_SimpleAPI.Services.Interfaces;

namespace CS_EntityFramework_SimpleAPI.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository iStudentRepository;
        private readonly ILogger<StudentService> iLogger;
        public StudentService(IStudentRepository iStudentRepository,
            ILogger<StudentService> iLogger)
        {
            this.iStudentRepository = iStudentRepository;
            this.iLogger = iLogger;
        }

        public async Task<ApiResponse> GetAllStudents()
        {
            ApiResponse apiResponse = await iStudentRepository.GetAllStudents();

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> GetStudentById(int id)
        {
            ApiResponse apiResponse = await iStudentRepository.GetStudentById(id);

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }              

        public async Task<ApiResponse> GetStudentsFilterByName(string name)
        {
            ApiResponse apiResponse = await iStudentRepository.
                GetStudentsFilterByName(name);

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Post(Student student)
        {
            ApiResponse apiResponse = await iStudentRepository.Post(student);

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Put(Student student)
        {
            ApiResponse apiResponse = await iStudentRepository.Put(student);

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Delete(int id)
        {
            ApiResponse apiResponse = await iStudentRepository.Delete(id);

            if (!apiResponse.Status)
            {
                iLogger.LogError(apiResponse.Message);
            }

            return apiResponse;
        }
    }
}
