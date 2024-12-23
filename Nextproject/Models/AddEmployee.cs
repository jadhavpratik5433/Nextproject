namespace Nextproject.Models
{
    public class AddEmployee
    {
        public required string Name { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
