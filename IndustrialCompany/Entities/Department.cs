using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Phone> Phones { get; set; } = new();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Project> Projects { get; set; }= new List<Project>();
        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
