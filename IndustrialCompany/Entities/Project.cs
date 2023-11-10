using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"{Id} {ProjectName} {StartDate}";
        }
    }
}
