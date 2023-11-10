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
    public class EmployeeConfiguartion : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(55).IsRequired();

            builder.Property(e => e.LName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(55).IsRequired();

            builder.Property(e=>e.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(70).IsRequired();

            builder.Property(x=>x.WorkDate)
                .HasColumnType("DATE").IsRequired();

            builder.HasMany(x => x.Children)
                .WithOne(x => x.Employee)
                .HasForeignKey(x => x.EmployeeId).IsRequired();

        }
    }
}
