using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Procedure
{
    public class GetDepartmentProjectsByID
    {
        public string? DepartmentName { get; set; }
        public string? ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public override string ToString()
        {
            return $"{DepartmentName} \t {ProjectName}\t {StartDate}";
        }
    }
}
