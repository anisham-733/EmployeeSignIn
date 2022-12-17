using EmployeeSignIn.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeSignIn.Services
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDetails> GetEmployeesByName(string FirstName,string LastName);
        IEnumerable<EmployeeDetails> GetAllEmployees();

    }
}
