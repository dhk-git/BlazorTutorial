﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DatabindingDemoBase : ComponentBase
    {
        public string Name { get; set; } = "Tom";
        public string Gender { get; set; } = "Male";

        public string Colour { get; set; } = "background-color:white";
    }
}
