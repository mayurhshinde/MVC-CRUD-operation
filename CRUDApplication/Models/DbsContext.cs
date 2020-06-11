using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class DbsContext : DbContext
    {
        public DbsContext()
        {
        }
        public DbsContext(DbContextOptions<DbsContext> options)
           : base(options)
        {
        }
        //public virtual DbSet<ResultDto> results { get; set; }
        public DbSet<TblEmployee> TblEmployee { get; set; }
        public DbSet<TblCity> tblCity { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<EmployeeVm>();
        }

        [Obsolete]
        public async Task<EmployeeVm> AddUpdateAsync(TblEmployee employee)
        {
            EmployeeVm lst = new EmployeeVm();
            try
            {
                var sqlParapm = new SqlParameter[] {
                new  SqlParameter ("@EmployeeId",employee.EmployeeId),
                new SqlParameter("@FirstName",employee.FirstName),
                new SqlParameter("@LastName",employee.LastName),
                new SqlParameter("@CityId",employee.CityId),
                new SqlParameter("@DOB",employee.DOB.ToString("yyyy-MM-dd"))
             };
                string sqlQuery = "EXEC spAddUpdateEmployee  " +
                                    "@EmployeeId , @FirstName , @LastName , @DOB , @CityId ";

                var result = await this.Query<EmployeeVm>().FromSql(sqlQuery, sqlParapm).ToListAsync();
                lst = result.SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }
    }
}
