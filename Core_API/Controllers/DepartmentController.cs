using Core_API.Models;
using Core_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDataAccessRepository<Department, int> deptServ;

        /// <summary>
        /// Inject the DataAccessRepositoryn using the Construtor injection 
        /// </summary>
        public DepartmentController(IDataAccessRepository<Department,int> deptServ)
        {
            this.deptServ = deptServ;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            var response = await deptServ.GetAsync();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await deptServ.GetAsync(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Department dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await IsDeptNameExist(dept))
                        throw new Exception($"The DeptName: {dept.DeptName} is already exist");
                    var response = await deptServ.CreateAsync(dept);
                    return Ok(response);
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Department dept)
        {
            var response = await deptServ.UpdateAsync(id, dept);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await deptServ.DeleteAsync(id);
            return Ok(response);
        }


        private async Task<bool> IsDeptNameExist(Department department)
        { 
            bool isExist = false;
            // Check for the Department based on DeptName
            var dept =  (from d in await deptServ.GetAsync()
                        where d.DeptName.Trim() == department.DeptName.Trim()
                        select d).FirstOrDefault();

            if (dept is Department)
                isExist = true; 
            
            return isExist;
        }


    }
}
