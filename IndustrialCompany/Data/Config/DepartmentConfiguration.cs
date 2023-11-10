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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.Property(x=>x.Name)
                .HasColumnType("VARCHAR")
                .HasMaxLength(55).IsRequired();

            builder.HasMany(x => x.Employees)
                .WithOne(x=>x.Department)
                .HasForeignKey(x=>x.DepartmentId).IsRequired();

            builder.HasMany(x => x.Phones)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId).IsRequired();
            
            builder.HasMany(x=>x.Projects)
                .WithOne(x=>x.Department)
                .HasForeignKey(x=>x.DepartmentId).IsRequired();
        }
    }
}
