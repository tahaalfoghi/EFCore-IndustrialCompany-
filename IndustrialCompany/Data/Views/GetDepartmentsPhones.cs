using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Views
{
    public class GetDepartmentsPhones
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{DeptId} {DeptName} {PhoneNumber}";
        }
    }
}
