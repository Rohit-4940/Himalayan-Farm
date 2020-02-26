using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlSalaryrepository : ISalary
    {
        private readonly Database _context;

        public SqlSalaryrepository(Database context)
        {
            this._context = context;
        }
        public Salary Add(Salary salary)
        {
            _context.salaries.Add(salary);
            _context.SaveChanges();
            return salary;
        }

        public Salary Delete(int id)
        {
            Salary hm = _context.salaries.Find(id);
            if (hm != null)
            {
                _context.salaries.Remove(hm);
                _context.SaveChanges();
            }
            return hm;
        }

        public IEnumerable<Salary> GetAllSalary()
        {
            return _context.salaries;
        }

        public Salary GetSalary(int id)
        {
            return _context.salaries.Find(id);
        }

        public Salary Update(Salary salary)
        {
            var hn = _context.salaries.Attach(salary);
            hn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return salary;
        }
    }
}
