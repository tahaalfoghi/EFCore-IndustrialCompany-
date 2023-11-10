using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Procedure
{
    public class DepartmentEmployees
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set;}
        public string? Email { get; set; }
        public override string ToString()
        {
            return $"DeptId:{DeptId}\t DeptName:{DeptName}\t EmployeeId:{EmployeeId}\t Name:{EmployeeName}\t Email:{Email}";
        }
    }
}
