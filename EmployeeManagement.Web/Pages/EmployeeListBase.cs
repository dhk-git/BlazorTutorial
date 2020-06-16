using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "John",
                lastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Abc"},
                Email = "adf@ddddd.com",
                PhotoPath = "images/john1.png"
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Johnaaa",
                lastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Abc" },
                Email = "adf@ddddd.com",
                PhotoPath = "images/john2.png"
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Johnbbbb",
                lastName = "Hastingbbs",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Abc" },
                Email = "adf@ddddd.com",
                PhotoPath = "images/john3.png"
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 4,
                FirstName = "Johncccddf",
                lastName = "Hastings",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Abc" },
                Email = "adsadfasdff@ddddd.com",
                PhotoPath = "images/john4.png"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
