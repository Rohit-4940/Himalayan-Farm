using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
    public interface Ileave
    {
        Leave GetLeave(int id);
        Leave Add(Leave leave);
        Leave Update(Leave leave);
        Leave Delete(int id);
        IEnumerable<Leave> GetAllLeave();
    }
}
