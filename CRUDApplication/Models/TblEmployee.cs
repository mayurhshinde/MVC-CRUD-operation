using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class TblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Required]
        [MaxLength(length: 100, ErrorMessage = "Maximum Length for First Name is 100 Character")]
        public string FirstName { get; set; }

        [Required]
           [MaxLength(length: 100, ErrorMessage = "Maximum Length for First Name is 100 Character")]
        public string LastName { get; set; }

        [Required]
        public DateTime DOB { get; set; }
        [Required]
       
        public int CityId { get; set; }
    }
}
