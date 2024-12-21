namespace CrudEmploye.Entities
{
    public class Profile
    {
        public int IdProfile { get; set; }
        public string? Name { get; set; }

        // Table Relationship
        public virtual ICollection<Employee>? ReferenceEmployee { get; set; }
    }
}
