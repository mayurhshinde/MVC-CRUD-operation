using CRUDApplication.Interface;
using CRUDApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Services
{
    public class CityService :  DAL<TblCity>, ICity
    {
        private readonly DbsContext _context;
        public CityService(DbsContext context) : base(context)
        {
            _context = context;
        }
        public List<TblCity> CityList()
        {
            return _context.tblCity.ToList();
        }
    }
}
