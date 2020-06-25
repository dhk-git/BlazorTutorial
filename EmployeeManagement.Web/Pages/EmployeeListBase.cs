using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        
        [Inject] //생성자에서 인잭션하지 않을수 있다
        public IEmployeeService EmployeeService{ get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();
            //await Task.Run(LoadEmployees);
            Employees = (await EmployeeService.GetEmployees()).ToList();

        }

        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(3000);
        //    Employee e1 = new Employee()
        //    {
        //        EmployeeId = 1,
        //        FirstName = "John",
        //        LastName = "Hastings",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 1,
        //        Email = "adf@ddddd.com",
        //        PhotoPath = "images/john1.png"
        //    };
        //    Employee e2 = new Employee()
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Johnaaa",
        //        LastName = "Hastings",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 2,
        //        Email = "adf@ddddd.com",
        //        PhotoPath = "images/john2.png"
        //    };
        //    Employee e3 = new Employee()
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Johnbbbb",
        //        LastName = "Hastingbbs",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 1,
        //        Email = "adf@ddddd.com",
        //        PhotoPath = "images/john3.png"
        //    };
        //    Employee e4 = new Employee()
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Johncccddf",
        //        LastName = "Hastings",
        //        DateOfBrith = new DateTime(1980, 10, 5),
        //        Gender = Gender.Male,
        //        DepartmentId = 3,
        //        Email = "adsadfasdff@ddddd.com",
        //        PhotoPath = "images/john4.png"
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4 };
        //}
    }
}
