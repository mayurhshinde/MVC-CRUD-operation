using CRUDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Interface
{
    public interface ICity
    {
        public List<TblCity> CityList();
    }
}
