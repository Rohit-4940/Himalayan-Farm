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
    public class VacancyController : Controller
    {
        private readonly IVacancy _vacancyrepository;

        public VacancyController(IVacancy vacancyrepository)
        {
            _vacancyrepository = vacancyrepository;
        }   // GET: /<controller>/
        public IActionResult Index()
        {
            var vac = _vacancyrepository.GetAllVacancy();
            return View(vac);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Vacancy vay)
        {
            if (ModelState.IsValid)
            {
                Vacancy vacancy = _vacancyrepository.Add(vay);
                return RedirectToAction("Index", new { id = vay.Id });
            }
            return View();
        }
        public ViewResult Detail(int? id)
        {
            var vac = _vacancyrepository.GetVacancy(id ?? 1);
            return View(vac);
        }
    }
}
