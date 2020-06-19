using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApplication.Interface;
using CRUDApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace CRUDApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly IEmployee _employee;
        private readonly ICity _city;
        public EmployeeAPIController(IEmployee employee, ICity city)
        {
            _employee = employee;
            _city = city;
        }

        [HttpGet("EmployeList")]
        public IActionResult EmployeList()
        {
            var result = _employee.ListEmployee();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("CityList")]
        public IActionResult CityList()
        {
            var result = _city.CityList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("GetEmployeeById")]
        public IActionResult GetEmployeeById(int id = 0)
        {
            TblEmployee employee = new TblEmployee();
            employee.DOB = DateTime.Now;
            if (id != 0)
                employee = _employee.GetEmployeeByID(id);

            if (employee == null)
                return NotFound();
            return Ok(employee);
        }
        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(TblEmployee employee)
        {
            if (ModelState.IsValid)
            {
                var ResultEmployee2 = await _employee.AddUpdate(employee);
                if (ResultEmployee2 == null)
                    return BadRequest(new { Message = "Some error Occurd" });
                employee.EmployeeId = ResultEmployee2.EmployeeId;

            }
            else
            { return BadRequest(new { Message = "Some error Occurd" }); }
            return Ok(employee);
        }

        [HttpGet("DeleteEmployee")]
        public IActionResult DeleteEmployee(int EmployeeID)
        {
            var result = _employee.DeleteEmployee(EmployeeID);
            if (result == true)
            {
                return Ok(new { Message = "Employee Deleted" });
            }
            else
            {
                return BadRequest(new { Message = "Some Error occurred" });
            }

        }
    }
}
