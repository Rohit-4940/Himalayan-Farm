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
    public class SalaryController : Controller
    {
        private readonly ISalary _salaryrepository;

        public SalaryController(ISalary salaryrepository)
        {
            _salaryrepository = salaryrepository;
        }   // GET: /<controller>/
        public IActionResult Index()
        {
            var sal = _salaryrepository.GetAllSalary();
            return View(sal);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Salary saly)
        {
            if (ModelState.IsValid)
            {
                Salary salary = _salaryrepository.Add(saly);
                return RedirectToAction("Index", new { id = saly.Id });
            }
            return View();
        }
        public ViewResult Detail(int? id)
        {
            var sal = _salaryrepository.GetSalary(id ?? 1);
            return View(sal);
        }
    }
}
