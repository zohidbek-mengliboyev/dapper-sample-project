namespace Dapper_ASP.NET_Project.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Position { get; set; }
        public int CompanyId { get; set; }
    }
}
