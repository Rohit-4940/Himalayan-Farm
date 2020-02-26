using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlDesignationrepository : Idesignation
    {
        private readonly Database _context;
        public SqlDesignationrepository(Database context)
        {
            this._context = context;
        }
        public Designation Add(Designation designation)
        {
            _context.designations.Add(designation);
            _context.SaveChanges();
            return designation;
        }

        public Designation Delete(int id)
        {
            Designation dg = _context.designations.Find(id);
            if (dg != null)
            {
                _context.designations.Remove(dg);
                _context.SaveChanges();
            }
            return dg;
        }

        public IEnumerable<Designation> GetAllDesignation()
        {
            return _context.designations;
        }

        public Designation GetDesignation(int id)
        {
            return _context.designations.Find(id);
        }

        public Designation Update(Designation designation)
        {
            var vn = _context.designations.Attach(designation);
            vn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return designation;
        }
    }
}
