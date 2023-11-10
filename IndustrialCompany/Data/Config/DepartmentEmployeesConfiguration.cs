using IndustrialCompany.Data.Procedure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Config
{
    public class DepartmentEmployeesConfiguration : IEntityTypeConfiguration<DepartmentEmployees>
    {
        public void Configure(EntityTypeBuilder<DepartmentEmployees> builder)
        {
            builder.HasNoKey();
        }
    }
}
