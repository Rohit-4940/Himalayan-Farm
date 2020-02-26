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
    public class DesignationController : Controller
    {
        private readonly Idesignation _designationrepository;

        public DesignationController(Idesignation designationrepository)
        {
            _designationrepository = designationrepository;
        }   // GET: /<controller>/
        public IActionResult Index()
        {
            var dg = _designationrepository.GetAllDesignation();
            return View(dg);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Designation deg)
        {
            if (ModelState.IsValid)
            {
                Designation designation = _designationrepository.Add(deg);
                return RedirectToAction("Index", new { id = deg.Id });
            }
            return View();
        }
        public ViewResult Detail(int? id)
        {
            var deg = _designationrepository.GetDesignation(id??1);
            return View(deg);
        }
    }
}
