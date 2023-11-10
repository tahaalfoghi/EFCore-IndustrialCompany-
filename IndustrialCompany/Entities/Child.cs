using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Entities
{
    public class Child
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"Name:{Name} Gender:{Gender} DOB:{DateOfBirth}";
        }
    }
}
