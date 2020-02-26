using HimalayanOrganicFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Repository.Interface
{
   public interface Idesignation
    {
        Designation Add(Designation designation);
        Designation Update(Designation designation);
        Designation Delete(int id);

        IEnumerable<Designation> GetAllDesignation();

        Designation GetDesignation(int id);
    }
}
