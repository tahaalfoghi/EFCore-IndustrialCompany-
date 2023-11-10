using IndustrialCompany.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCompany.Data
{
    // using Sigleton Pattern
    public class SeedData
    {
        private SeedData() { }
        private static SeedData _instance = new();
        private static object _lock = new();

        public static SeedData Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SeedData();
                    }
                }
                return _instance;
            }
        }
        public List<Department> LoadDepartments()
        {
            return new List<Department>
            {
               new Department { Id = 1, Name = "Marketing" },
               new Department { Id = 2, Name = "Human Resources" },
               new Department { Id = 3, Name = "Finance" },
               new Department { Id = 4, Name = "Operations" },
               new Department { Id = 5, Name = "Sales" },
               new Department { Id = 6, Name = "Information Technology" },
               new Department { Id = 7, Name = "Research and Development" },
               new Department { Id = 8, Name = "Customer Service" },
               new Department { Id = 9, Name = "Production" },
               new Department { Id = 10, Name = "Supply Chain" }
            };
        }
        public List<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee {Id= 1, FName="Sam", LName="Alex", Email="SamAlex@example.com", DepartmentId=1},
                new Employee {Id= 2, FName="Lewis", LName="Jackson", Email="LewisJackson@example.com", DepartmentId=4},
                new Employee {Id= 3, FName="Saul", LName="Canelo", Email="SaulCanelo@example.com", DepartmentId=3},
                new Employee {Id= 4, FName="Mike", LName="White", Email="MikeWhite@example.com", DepartmentId=2},
                new Employee {Id= 5, FName="Mark", LName="Alex", Email="MarkAlex@example.com", DepartmentId=5},
                new Employee {Id= 6, FName="Fede", LName="Chiesa", Email="FedeChiesa@example.com", DepartmentId=6},
                new Employee {Id= 7, FName="Antony", LName="Paex", Email="Antony001@example.com", DepartmentId=7},
                new Employee {Id= 8, FName="Sedny", LName="Sam", Email="Sedny88@example.com", DepartmentId=9},
                new Employee {Id= 9, FName="Mike", LName="Alex", Email="MikeS@example.com", DepartmentId=8},
                new Employee {Id= 10,FName="Tyson", LName="Wilder", Email="tyson77@example.com", DepartmentId=10},
            };
        }
        public List<Phone> LoadPhones()
        {
            return new List<Phone>
            {
                new Phone {Id=1, PhoneNumber = "555-1234",  DepartmentId=3},
                new Phone {Id=2, PhoneNumber = "555-5678",  DepartmentId=6},
                new Phone {Id=3, PhoneNumber = "555-9876",  DepartmentId=2},
                new Phone {Id=4, PhoneNumber = "555-2468",  DepartmentId=1},
                new Phone {Id=5, PhoneNumber = "555-1357",  DepartmentId=5},
                new Phone {Id=6, PhoneNumber = "555-8642",  DepartmentId=8},
                new Phone {Id=7, PhoneNumber = "555-3698",  DepartmentId=7},
                new Phone {Id=8, PhoneNumber = "555-7584",  DepartmentId=4},
                new Phone {Id=9, PhoneNumber = "555-4826",  DepartmentId=9},
                new Phone {Id=10,PhoneNumber = "555-9713",  DepartmentId=10},
            };
        }
        public List<Child> LoadChildren()
        {
            return new List<Child>
            {
               new Child { EmployeeId = 1, Name = "John Smith", Gender = "Male", DateOfBirth = new DateTime(2005-03-15 )},
               new Child { EmployeeId = 1, Name = "Emily Johnson", Gender = "Female", DateOfBirth = new DateTime(2008-09-23) },
               new Child { EmployeeId = 2, Name = "Michael Brown", Gender = "Male", DateOfBirth = new DateTime(2007 - 07 - 10) },
               new Child { EmployeeId = 3, Name = "Sophia Davis", Gender = "Female", DateOfBirth = new DateTime(2009-12-05) },
               new Child { EmployeeId = 4, Name = "William Anderson", Gender = "Male", DateOfBirth = new DateTime(2006-06-20) },
               new Child { EmployeeId = 5, Name = "Olivia Garcia", Gender = "Female", DateOfBirth = new DateTime(2010-02-12) },
               new Child { EmployeeId = 6, Name = "James Martinez", Gender = "Male", DateOfBirth = new DateTime(2004-11-30) },
               new Child { EmployeeId = 7, Name = "Ava Wilson", Gender = "Female", DateOfBirth = new DateTime(2007-04-18) },
               new Child { EmployeeId = 8, Name = "Logan Taylor", Gender = "Male", DateOfBirth = new DateTime(2009-10-07) },
               new Child { EmployeeId = 9, Name = "Mia Clark", Gender = "Female", DateOfBirth = new DateTime(2005-08-25) }
            };
        }
        public List<Project> LoadProjects()
        {
            return new List<Project>
            {
               new Project { Id = 1, ProjectName = "Project A", StartDate = new DateTime(2023, 1, 1), DepartmentId = 1 },
               new Project { Id = 2, ProjectName = "Project B", StartDate = new DateTime(2022, 5, 15), DepartmentId = 2 },
               new Project { Id = 3, ProjectName = "Project C", StartDate = new DateTime(2023, 3, 10), DepartmentId = 6 },
               new Project { Id = 4, ProjectName = "Project D", StartDate = new DateTime(2022, 9, 30), DepartmentId = 7 },
               new Project { Id = 5, ProjectName = "Project E", StartDate = new DateTime(2023, 6, 20), DepartmentId = 9 },
               new Project { Id = 6, ProjectName = "Project F", StartDate = new DateTime(2022, 2, 5), DepartmentId = 5 },
               new Project { Id = 7, ProjectName = "Project G", StartDate = new DateTime(2023, 8, 12), DepartmentId = 3 },
               new Project { Id = 8, ProjectName = "Project H", StartDate = new DateTime(2022, 12, 1), DepartmentId = 2 },
               new Project { Id = 9, ProjectName = "Project I", StartDate = new DateTime(2023, 4, 25), DepartmentId = 10 },
               new Project { Id = 10,ProjectName = "Project J", StartDate = new DateTime(2022, 7, 8), DepartmentId = 3 }
            };
        }

    }
}
