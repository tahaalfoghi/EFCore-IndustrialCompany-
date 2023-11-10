using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Views
{
    public class GetDepartmentsProjects
    {
        public string? DepartmentName { get; set; }
        public string? ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public override string ToString()
        {
            return $"{DepartmentName} {ProjectName} {StartDate}";
        }
    }
}
