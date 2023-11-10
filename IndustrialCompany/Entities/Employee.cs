using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public DateTime WorkDate { get; set; }
        public ICollection<Child> Children { get; set; } = new List<Child>();
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string? Name => FName + " " + LName;
        public override string ToString()
        {
            return $"{Id} {Name} {Email} {WorkDate}";
        }
    }
}
