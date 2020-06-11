using CRUDApplication.Models;
using CRUDApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Interface
{
    public interface IEmployee
    {
        Task<EmployeeVm> AddUpdate(TblEmployee employee);
        List<EmployeeListVm> ListEmployee();
        TblEmployee GetEmployeeByID(int id);
        bool DeleteEmployee(int EmployeeID);
    }
}
