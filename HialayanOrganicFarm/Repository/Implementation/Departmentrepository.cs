using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class Departmentrepository : IDepartment
    {
        private List<Department> _DepartmentList;
        public Departmentrepository()
        {
            _DepartmentList = new List<Department>()
            {
                new Department(){Id=1,Title="HR",Description="HR" }
            };
        }
        public Department Add(Department department)
        {
            department.Id = _DepartmentList.Max(e => e.Id) + 1;
            _DepartmentList.Add(department);
            return department;
        }

        public Department Delete(int id)
        {
            Department department = _DepartmentList.FirstOrDefault(e => e.Id == id);
            if (department != null)
            {
                _DepartmentList.Remove(department);
            }
            return department;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _DepartmentList;
        }

        public Department GetDepartment(int id)
        {
            return _DepartmentList.FirstOrDefault(e => e.Id == id);
        }

        public Department Update(Department department)
        {
            return department;
        }
    }
}
