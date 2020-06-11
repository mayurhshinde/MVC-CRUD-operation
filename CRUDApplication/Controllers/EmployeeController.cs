using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDApplication.Interface;
using CRUDApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        private readonly ICity _city;
        public EmployeeController(IEmployee employee, ICity city)
        {
            _employee = employee;
            _city = city;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["Message"]!=null)
            {
                ViewBag.Message = TempData["Message"];
            }
            var result = _employee.ListEmployee();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddUpdateEmployee(int? ID)
        {
            ViewBag.City = _city.CityList();
            TblEmployee employee = new TblEmployee();
            employee.DOB = DateTime.Now;
            if (ID != null)
                if (ID.Value > 0)
                {
                    employee = _employee.GetEmployeeByID(ID.Value);
                }
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddUpdateEmployee(TblEmployee employee)
        {
            ViewBag.City = _city.CityList();
            if (ModelState.IsValid)
            {
                string msg = "Employee Updated";
                var ResultEmployee2 = await _employee.AddUpdate(employee);
                if (employee.EmployeeId == 0)
                {
                    msg = "Employee Added";
                }
                employee.EmployeeId = ResultEmployee2.EmployeeId;
                ViewBag.Message = msg;
            }
            return View(employee);
        }

        [HttpGet]
        public IActionResult DeleteEmployee(int EmployeeID)
        {
            var result = _employee.DeleteEmployee(EmployeeID);
            if (result == true)
            {
                TempData["Message"] = "Employee Deleted";
            }
            else
            {
                TempData["Message"] = "Some Error occurred";
            }
            return RedirectToAction("Index");
        }
    }
}
