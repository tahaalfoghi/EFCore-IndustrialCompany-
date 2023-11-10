using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Procedure
{
    public class GetDepartmentPhonesById
    {
        public string? DepartmentName { get; set; }
        public string? PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{DepartmentName} {PhoneNumber}";
        }
    }
}
