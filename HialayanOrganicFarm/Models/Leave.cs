using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Models
{
    public class Leave
    {
        public int Id { get; set; }
        [Required]
        public Employee employee { get; set; }
        [Required]
        public string leave_type { get; set; }
        [Required]
        public int from_date { get; set; }
        [Required]
        public int to_date { get; set; }
        [Required]
        public int no_days { get; set; }
        [Required]
        public string description { get; set; }
    }
}
