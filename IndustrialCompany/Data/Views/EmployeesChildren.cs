using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Views
{
    public class EmployeesChildren
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? ChildeName { get; set; }
        public override string ToString()
        {
            return $"{EmployeeId} {EmployeeName} {ChildeName}";
        }
    }
}
