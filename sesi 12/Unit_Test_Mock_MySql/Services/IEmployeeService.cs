using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unit_Test_Mock.Models;

namespace Unit_Test_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}