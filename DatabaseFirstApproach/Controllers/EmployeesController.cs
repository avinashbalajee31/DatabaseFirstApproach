using DatabaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirstApproach.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
       
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>();
            using (var context = new employeesContext())
            {
                employees = context.Employees.ToList();
            }
            return employees;
        }

       
    }
}
