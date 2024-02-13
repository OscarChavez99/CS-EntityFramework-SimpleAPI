using Microsoft.AspNetCore.Mvc;
using CS_EntityFramework_SimpleAPI.Services.Interfaces;
using CS_EntityFramework_SimpleAPI.Models;

namespace CS_EntityFramework_SimpleAPI.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService iStudentService;

        public StudentController(IStudentService iStudentService)
        {
            this.iStudentService = iStudentService;
        }

        [HttpGet("GetAllStudents")]
        public async Task<ApiResponse> GetAllStudents()
        {
            ApiResponse apiResponse = await iStudentService.GetAllStudents();
            return apiResponse;
        }

        [HttpGet("GetStudentBy/{id}")]
        public async Task<ApiResponse> GetStudentById(int id)
        {
            ApiResponse apiResponse = await iStudentService.GetStudentById(id);
            return apiResponse;
        }

        [HttpGet("GetStudentsFilterBy/{name}")]
        public async Task<ApiResponse> GetStudentsFilterByName(string name)
        {
            ApiResponse apiResponse = await iStudentService
                .GetStudentsFilterByName(name);

            return apiResponse;
        }

        [HttpPost]
        public async Task<ApiResponse> Post([FromBody] Student student)
        {
            ApiResponse apiResponse = await iStudentService.Post(student);
            return apiResponse;
        }

        [HttpPut]
        public async Task<ApiResponse> Put([FromBody] Student student)
        {
            ApiResponse apiResponse = await iStudentService.Put(student);
            return apiResponse;
        }

        [HttpDelete]
        public async Task<ApiResponse> Delete(int id)
        {
            ApiResponse apiResponse = await iStudentService.Delete(id);
            return apiResponse;
        }
    }
}
