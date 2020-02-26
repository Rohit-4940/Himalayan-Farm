using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        Employee Delete(int id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
