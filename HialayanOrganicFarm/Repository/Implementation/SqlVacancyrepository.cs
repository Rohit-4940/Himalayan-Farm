using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlVacancyrepository : IVacancy
    {
        private readonly Database _context;
        public SqlVacancyrepository(Database context)
        {
            this._context = context;
        }
        public Vacancy Add(Vacancy vacancy)
        {
            _context.vacancies.Add(vacancy);
            _context.SaveChanges();
            return vacancy;
        }

        public Vacancy Delete(int id)
        {
            Vacancy hm = _context.vacancies.Find(id);
            if (hm != null)
            {
                _context.vacancies.Remove(hm);
                _context.SaveChanges();
            }
            return hm;
        }

        public IEnumerable<Vacancy> GetAllVacancy()
        {
            return _context.vacancies;
        }

        public Vacancy GetVacancy(int id)
        {
            return _context.vacancies.Find(id);
        }

        public Vacancy Update(Vacancy vacancy)
        {
            var hn = _context.vacancies.Attach(vacancy);
            hn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return vacancy;
        }
    }
}
