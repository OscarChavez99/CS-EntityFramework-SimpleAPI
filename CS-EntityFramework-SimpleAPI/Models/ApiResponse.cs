namespace CS_EntityFramework_SimpleAPI.Models
{
    public class ApiResponse
    {
        public bool Status { get; set; }
        public object? Data { get; set; }
        public string? Message { get; set; }
    }
}
