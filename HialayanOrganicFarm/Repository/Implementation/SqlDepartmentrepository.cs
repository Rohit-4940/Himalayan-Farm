using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlDepartmentrepository : IDepartment
    {
        private readonly Database _context;
        public SqlDepartmentrepository(Database context)
        {
            this._context = context;
        }
        public Department Add(Department department)
        {
            _context.departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public Department Delete(int Id)
        {
            Department de = _context.departments.Find(Id);
            if (de != null)
            {
                _context.departments.Remove(de);
                _context.SaveChanges();
            }
            return de;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _context.departments;
        }

        public Department GetDepartment(int Id)
        {
            return _context.departments.Find(Id);
        }

        public Department Update(Department department)
        {
            var hn = _context.departments.Attach(department);
            hn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return department;
        }
    }
}
