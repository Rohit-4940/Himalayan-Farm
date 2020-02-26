using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Implementation
{
    public class SqlLeaverepository : Ileave
    {
        private readonly Database _context;

        public SqlLeaverepository(Database context)
        {
            this._context = context;
        }
        public Leave Add(Leave leave)
        {
            _context.leaves.Add(leave);
            _context.SaveChanges();
            return leave;
        }

        public Leave Delete(int id)
        {
            Leave hm = _context.leaves.Find(id);
            if (hm != null)
            {
                _context.leaves.Remove(hm);
                _context.SaveChanges();
            }
            return hm;
        }

        public IEnumerable<Leave> GetAllLeave()
        {
            return _context.leaves;
        }

        public Leave GetLeave(int id)
        {
            return _context.leaves.Find(id);
        }

        public Leave Update(Leave leave)
        {
            var hn = _context.leaves.Attach(leave);
            hn.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return leave;
        }
    }
}
