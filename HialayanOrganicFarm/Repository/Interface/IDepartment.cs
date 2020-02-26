using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
    public interface IDepartment
    {
        Department GetDepartment(int Id);
        Department Add(Department department);
        IEnumerable<Department> GetAllDepartment();

        Department Update(Department department);
        Department Delete(int Id);


    }
}
