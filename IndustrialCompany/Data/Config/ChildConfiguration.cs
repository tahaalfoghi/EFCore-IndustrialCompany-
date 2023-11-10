using IndustrialCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data.Config
{
    public class ChildConfiguration : IEntityTypeConfiguration<Child>
    {
        public void Configure(EntityTypeBuilder<Child> builder)
        {
            builder.ToTable(nameof(Child));
            builder.HasKey(x => new { x.EmployeeId, x.Name });

            builder.Property(x=>x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(55).IsRequired();

            builder.Property(x => x.DateOfBirth).HasColumnType("DATE");
        }
    }
}
