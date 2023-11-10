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
    public class GetDepartmentProjectsByIConfiguration : IEntityTypeConfiguration<GetDepartmentProjectsByID>
    {
        public void Configure(EntityTypeBuilder<GetDepartmentProjectsByID> builder)
        {
            builder.HasNoKey();
        }
    }
}
