using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepository repository;

        public EmployeesController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return repository.GetEmployees();
        }

        // GET api/employees/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return this.repository.GetEmployee(id);
        }

        // POST api/employees
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            this.repository.Add(employee);
        }

        // PUT api/employees/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Employee employee)
        {
            this.repository.Update(id, employee);
        }

        // DELETE api/employees/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.Remove(id);
        }
    }
}
