using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Models
{
    public class Salary
    {
        public int Id { get; set; }
        [Required]
        public Employee employee { get; set; }
        [Required]
        public int select_month { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public int date { get; set; }
        [Required]
        public string description { get; set; }
    }
}
