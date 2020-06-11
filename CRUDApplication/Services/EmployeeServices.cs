using CRUDApplication.Interface;
using CRUDApplication.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Services
{
    public class EmployeeServices : DAL<TblEmployee>, IEmployee
    {
        private readonly DbsContext _context;
        public EmployeeServices(DbsContext context) : base(context)
        {
            _context = context;
        }

        [Obsolete]
        public async Task<EmployeeVm> AddUpdate(TblEmployee employee)
        {
            return await _context.AddUpdateAsync(employee);
        }


        public bool DeleteEmployee(int EmployeeID)
        {
            var result = _context.TblEmployee.Find(EmployeeID);
            if (result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<EmployeeListVm> ListEmployee()
        {
            var result = (from db in _context.TblEmployee
                          join cc in _context.tblCity on db.CityId equals cc.Id
                          select new EmployeeListVm
                          {
                              Age = Convert.ToInt32(DateTime.Now.Year - db.DOB.Year),
                              DOB = db.DOB,
                              CityId = db.CityId,
                              EmployeeId = db.EmployeeId,
                              FirstName = db.FirstName,
                              LastName = db.LastName,
                              CityName = cc.CityName
                          }).ToList();
            return result;
        }

        public TblEmployee GetEmployeeByID(int id)
        {
            TblEmployee tblEmployee = new TblEmployee();
            tblEmployee = _context.TblEmployee.Find(id);
            return tblEmployee;
        }
    }
}
