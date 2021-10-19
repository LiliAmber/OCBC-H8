using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Unit_Test_Mock.Models;
using Unit_Test_Mock.Data;

namespace Unit_Test_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Constructor
        public EmployeeService(ApiDbContext apiDbContext) 
        {
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetEmployeebyId(int EmpID)
        {
            var name = await _apiDbContext.Employees.Where(c => c.Id == EmpID).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            
            var emp = await _apiDbContext.Employees.FirstOrDefaultAsync(c => c.Id == EmpID);
            return emp;
        }
    }
}