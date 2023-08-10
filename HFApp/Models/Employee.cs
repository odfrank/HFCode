namespace HFApp.Models
{
    public enum RoleType
    {
        Admin1,
        Admin2,
        General
    }
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string?  RoleType { get; set; }        
    }
}
