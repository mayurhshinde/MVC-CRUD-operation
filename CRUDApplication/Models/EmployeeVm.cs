using CRUDApplication.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class EmployeeVm
    { 
        public int EmployeeId { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime DOB { get; set; } 
        public int CityId { get; set; }
    }


    public class EmployeeListVm
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        public int CityId { get; set; } 
        public string CityName { get; set; }
    }

}
