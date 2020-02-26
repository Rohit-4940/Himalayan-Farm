using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Department department { get; set; }
        [Required]
        public Designation designation { get; set; }
        [Required]
        public string  Email { get; set; }
     
    }
}
