using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Models
{
    public class Designation
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string description { get; set; }
    }
}
