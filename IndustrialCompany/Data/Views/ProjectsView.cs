using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Views
{
    public class ProjectsView
    {
        public string? ProjectName { get; set; }
        public string? DepartmentName { get; set; }
        public override string ToString()
        {
            return $"{ProjectName} {DepartmentName}";
        }
    }
}
