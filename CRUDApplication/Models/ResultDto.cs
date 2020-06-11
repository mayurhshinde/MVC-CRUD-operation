using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class ResultDto
    {
        public int EmployeeId { get; set; }
        public string StatusMessgae { get; set; }


        public TblEmployee EmployeeDetail { get; set; }
    }
}
