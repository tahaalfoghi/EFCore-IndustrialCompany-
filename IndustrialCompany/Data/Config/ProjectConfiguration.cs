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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable(nameof(Project));
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.Property(x=>x.ProjectName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(55).IsRequired();

            builder.Property(x => x.StartDate).HasColumnType("DATE");

            builder.Property(x => x.StartDate).HasColumnType("Date").IsRequired();

        }
    }
}
