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
    public class LeaveController : Controller
    {
        private readonly Ileave _leaverepository;

        public LeaveController(Ileave leaverepository)
        {
            _leaverepository = leaverepository;
        }   // GET: /<controller>/
        public IActionResult Index()
        {
            var lev = _leaverepository.GetAllLeave();
            return View(lev);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Leave lev)
        {
            if (ModelState.IsValid)
            {
                Leave leave = _leaverepository.Add(lev);
                return RedirectToAction("Index", new { id = lev.Id });
            }
            return View();
        }
        public ViewResult Detail(int? id)
        {
            var lev = _leaverepository.GetLeave(id ?? 1);
            return View(lev);
        }
    }

}
