using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
    public interface IVacancy
    {
        Vacancy GetVacancy(int id);
        Vacancy Add(Vacancy vacancy);
        Vacancy Update(Vacancy vacancy);
        IEnumerable<Vacancy> GetAllVacancy();
        Vacancy Delete(int id);
    }
}
