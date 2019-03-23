using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repository
{
    public class MockRepository : IRepository
    {
        private readonly List<Employee> employees;

        public MockRepository()
        {
            this.employees = new List<Employee>();
            this.employees.Add(new Employee()
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Age = 22,
                Position = "Junior"
            });
            this.employees.Add(new Employee()
            {
                Id = 2,
                FirstName = "Krzysztof",
                LastName = "Bąk",
                Age = 21,
                Position = "Junior"
            });
            this.employees.Add(new Employee()
            {
                Id = 3,
                FirstName = "Jakub",
                LastName = "Kowalski",
                Age = 26,
                Position = "Senior"
            });
        }

        public void Add(Employee employee)
        {
            this.employees.Add(employee);
        }

        public Employee GetEmployee(int id)
        {
            return this.employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        public void Remove(int id)
        {
            var employee = this.employees.FirstOrDefault(e => e.Id == id);
            this.employees.Remove(employee);
        }

        public void Update(int id, Employee employee)
        {
            var emp = this.employees.Where(e => e.Id == id).FirstOrDefault();
            emp.Age = employee.Age;
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Position = employee.Position;
        }
    }
}
