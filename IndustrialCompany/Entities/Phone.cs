using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public string? PhoneNumber { get; set; }    
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return $"{PhoneNumber} {DepartmentId}";
        }
    }
}
