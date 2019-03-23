using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repository
{
    public interface IRepository
    {
        void Add(Employee employee);
        void Remove(int id);
        void Update(int id,  Employee employee);

        List<Employee> GetEmployees();
        Employee GetEmployee(int id);

    }
}
