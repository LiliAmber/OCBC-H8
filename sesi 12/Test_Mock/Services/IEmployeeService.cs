using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Mock.Models;

namespace Test_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int EmpID);
        Task<Employee> GetEmployeeDetails(int EmpID);
    }
}