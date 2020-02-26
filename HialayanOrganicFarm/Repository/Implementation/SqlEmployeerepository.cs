using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlEmployeerepository : IEmployee
    {
        private readonly Database _context;
        public SqlEmployeerepository(Database context)
        {
            this._context = context;
        }
        public Employee Add(Employee employee)
        {
            _context.employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee hm = _context.employees.Find(id);
            if (hm != null)
            {
                _context.employees.Remove(hm);
                _context.SaveChanges();
            }
            return hm;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.employees;
        }

        public Employee GetEmployee(int id)
        {
            return _context.employees.Find(id);
        }

        public Employee Update(Employee employee)
        {
            var hn = _context.employees.Attach(employee);
            hn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employee;
        }
    }
}
