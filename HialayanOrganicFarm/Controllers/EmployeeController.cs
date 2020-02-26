using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HimalayanOrganicFarm.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employeerepository;

        public EmployeeController(IEmployee employeerepository)
        {
            _employeerepository = employeerepository;
        }   // GET: /<controller>/
        public IActionResult Index()
        {
            var emp = _employeerepository.GetAllEmployee();
            return View(emp);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Employee eyl)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeerepository.Add(eyl);
                return RedirectToAction("Index", new { id = eyl.Id });
            }
            return View();
        }
        public ViewResult Detail(int? id)
        {
            var emp = _employeerepository.GetEmployee(id ?? 1);
            return View(emp);
        }
    }
}
