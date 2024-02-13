using CS_EntityFramework_SimpleAPI.Models;
using CS_EntityFramework_SimpleAPI.Repositories.DBContexts;
using CS_EntityFramework_SimpleAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace CS_EntityFramework_SimpleAPI.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly AppDbContext dbContext;
        public StudentRepository(AppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<ApiResponse> GetAllStudents()
        {
            ApiResponse apiResponse = new();
            try
            {
                // This is equivalent to executing the SQL query
                // "SELECT * FROM students"
                List<Student> students = await dbContext.Students.ToListAsync();
                
                apiResponse.Status  = true;
                apiResponse.Data    = students;
                apiResponse.Message = "Students retrieved successfully";
            }
            catch (Exception ex)
            {
                apiResponse.Message = $"Error: {ex.Message} ";
            }

            return apiResponse;
        }

        public async Task<ApiResponse> GetStudentById(int id)
        {
            ApiResponse apiResponse = new();

            try
            {
                // Retrieves the "Student" record with the specified primary key (id).
                Student? student = await dbContext.Students.FindAsync(id);

                apiResponse.Status  = true;
                apiResponse.Data    = student;

                if (student != null)
                {
                    apiResponse.Message = "Student retrieved successfully";
                }
                else
                {
                    apiResponse.Message = $"No Student found with ID: {id}";
                }
            }
            catch(Exception ex)
            {
                apiResponse.Message = $"Error: {ex.Message}";
            }

            return apiResponse;
        }

        public async Task<ApiResponse> GetStudentsFilterByName(string name)
        {
            ApiResponse apiResponse = new();

            try
            {
                // This is equivalent to executing the SQL query
                // "SELECT * FROM students WHERE name LIKE '%name%'"
                List<Student> filteredStudents = await dbContext.Students
                    .Where(student => EF.Functions.Like(student.Name, $"%{name}%"))
                    .ToListAsync();

                apiResponse.Status = true;
                apiResponse.Data   = filteredStudents;

                if (filteredStudents.Any())
                {
                    apiResponse.Message = "Students filtered successfully";
                }
                else
                {
                    apiResponse.Message = $"No Student found with {name}";
                }
            }
            catch(Exception ex )
            {
                apiResponse.Message = $"Error: {ex.Message}";
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Post(Student student)
        {
            ApiResponse apiResponse = new();

            try
            {
                // Inserts a new "Student" record into the database
                await dbContext.Students.AddAsync(student);
                // In Entity Framework, changes must be saved to persist write operations
                await dbContext.SaveChangesAsync();
                apiResponse.Status = true;
                apiResponse.Message = "Student inserted successfully";
            }
            catch(Exception ex)
            {
                apiResponse.Message = $"Error: {ex.Message}";
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Put(Student student)
        {
            ApiResponse apiResponse = new();

            try
            {
                // This is equivalent to executing an "UPDATE" SQL Query
                dbContext.Students.Update(student);
                // In Entity Framework, changes must be saved to persist write operations
                await dbContext.SaveChangesAsync();

                apiResponse.Status  = true;
                apiResponse.Message = "Student updated successfully";
            }
            catch(Exception ex)
            {
                apiResponse.Message = $"Error: {ex.Message}";
            }

            return apiResponse;
        }

        public async Task<ApiResponse> Delete(int id)
        {
            ApiResponse apiResponse = new();

            try
            {
                Student? studentToDelete = await dbContext.Students.FindAsync(id);

                apiResponse.Status = true;

                if (studentToDelete != null)
                {
                    // Removes the specified "Student" record from the database
                    dbContext.Students.Remove(studentToDelete);
                    // In Entity Framework, changes must be saved to persist write operations
                    await dbContext.SaveChangesAsync();
                    
                    apiResponse.Message = "Student deleted successfully";
                }

                else
                {
                    apiResponse.Message = $"No Student found with ID: {id}";
                }

            }
            catch(Exception ex)
            {
                apiResponse.Message = $"Error: {ex.Message}";
            }

            return apiResponse;
        }
    }
}
