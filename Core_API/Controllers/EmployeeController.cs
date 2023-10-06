using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IDataResponseService<Employee, int> empServ;

        /// <summary>
        /// Dependency Injection for EmployeeDataAccessRepository
        /// </summary>
        /// <param name="empServ"></param>
        public EmployeeController(IDataResponseService<Employee, int> empServ)
        {
            this.empServ = empServ;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var response = await empServ.GetAsync();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await empServ.GetAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Employee emp)
        {
            var response = await empServ.CreateAsync(emp);
            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,Employee emp)
        {
            var response = await empServ.UpdateAsync(id,emp);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await empServ.DeleteAsync(id);
            return Ok(response);
        }

    }
}
