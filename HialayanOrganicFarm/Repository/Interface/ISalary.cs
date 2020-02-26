using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
    public interface ISalary
    {
        Salary GetSalary(int id);
        Salary Add(Salary salary);
        Salary Update(Salary salary);
        Salary Delete(int id);
        IEnumerable<Salary> GetAllSalary();
    }
}
