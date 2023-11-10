using IndustrialCompany.Data.Procedure;
using IndustrialCompany.Data.Views;
using IndustrialCompany.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }  
        public DbSet<Child> Children { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<DepartmentEmployees> DepartmentEmployees { get; set; }
        public DbSet<GetDepartmentPhonesById> GetDepartmentPhonesById { get; set; }
        public DbSet<GetDepartmentsPhones> GetDepartmentsPhones { get; set; }
        public DbSet<GetDepartmentProjectsByID> GetDepartmentProjectsByID { get; set; }
        public DbSet<GetDepartmentsProjects> GetDepartmentsProjects { get; set; }
        public DbSet<EmployeesChildren> EmployeesChildren { get; set; }
        public DbSet<ProjectsView> ProjectsView { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=IndustrialCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<GetDepartmentsPhones>().HasNoKey().ToView("GetDepartmentsPhones");
            modelBuilder.Entity<GetDepartmentsProjects>().HasNoKey().ToView("GetDepartmentsProjects");
            modelBuilder.Entity<EmployeesChildren>().HasNoKey().ToView("EmployeesChildren");
            modelBuilder.Entity<ProjectsView>().HasNoKey().ToView("ProjectsView");
        }
    }
}
