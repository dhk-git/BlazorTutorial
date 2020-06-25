using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                Email = "adf@ddddd.com",
                PhotoPath = "images/john1.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johnaaa",
                LastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 2,
                Email = "adf@ddddd.com",
                PhotoPath = "images/john2.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                EmployeeId = 3,
                FirstName = "Johnbbbb",
                LastName = "Hastingbbs",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                Email = "adf@ddddd.com",
                PhotoPath = "images/john3.png"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                EmployeeId = 4,
                FirstName = "Johncccddf",
                LastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 3,
                Email = "adsadfasdff@ddddd.com",
                PhotoPath = "images/john4.png"
            });

        }
    }
}
