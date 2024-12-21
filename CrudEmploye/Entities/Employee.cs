namespace CrudEmploye.Entities
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public string? FullName { get; set; }
        public int Salary { get; set; }
        
        // Table Relationship
        public int IdProfile { get; set; }
        public virtual Profile? ReferenceProfile { get; set; }
    }
}
