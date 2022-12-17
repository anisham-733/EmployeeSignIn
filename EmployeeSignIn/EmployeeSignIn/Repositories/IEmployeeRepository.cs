using EmployeeSignIn.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeSignIn.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDetails> GetEmployeesByName(string FirstName, string LastName);
        IEnumerable<EmployeeDetails> GetAllEmployees();
    }
}
