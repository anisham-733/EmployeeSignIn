using EmployeeSignIn.DBContext;
using EmployeeSignIn.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSignIn.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeSigningSystemContext _DbContext;
        public EmployeeRepository(EmployeeSigningSystemContext context)
        {
            _DbContext = context;
        }

        public IEnumerable<EmployeeDetails> GetAllEmployees()
        {


            var employees=_DbContext.EmployeeDetails.ToList();
            return employees;
        }

        public  IEnumerable<EmployeeDetails> GetEmployeesByName(string FirstName, string LastName)
        {
            
            IEnumerable<EmployeeDetails> matchingRecords=_DbContext.EmployeeDetails.
                Where(emp=>emp.FirstName.Contains(FirstName)|| emp.LastName.Contains(LastName)).ToList();

            return  matchingRecords;
        }
    }
}
