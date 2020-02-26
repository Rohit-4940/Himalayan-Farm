using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimalayanOrganicFarm.Models
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> data) : base(data)
        {

        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Designation> designations { get; set; }
        public DbSet<Vacancy> vacancies { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Leave> leaves { get; set; }
        public DbSet<Salary> salaries { get; set; }
    }
}
