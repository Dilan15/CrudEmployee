namespace CrudEmploye.DTOs
{
    public class EmployeeDTO
    {
        public string? FullName { get; set; }
        public int Salary { get; set; }

        // Table Relationship
        public int IdProfile { get; set; }
    }
}
