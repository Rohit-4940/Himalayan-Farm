using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HimalayanOrganicFarm.Models;
using HimalayanOrganicFarm.Repository.Interface;
using HimalayanOrganicFarm.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HimalayanOrganicFarm.Controllers
{
    public class DepartmentController : Controller
    {
        private  IDepartment _departmentrepository;

        public DepartmentController(IDepartment departmentrepository)
        {
            _departmentrepository = departmentrepository;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Department dep )
        {
            if (ModelState.IsValid)
            {
                Department department = _departmentrepository.Add(dep);
                return RedirectToAction("index", new { id = dep.Id });
            }
            return View();
        }
        public ViewResult index()
        {
            var model = _departmentrepository.GetAllDepartment();
            return View(model);
        }
        public IActionResult delete(int id)
        {
            Department de = _departmentrepository.Delete(id);
            return View();
        }
        public ViewResult Detail(int? id)
        {
            DepartmentDetailViewModels departmentDetailViewModels = new DepartmentDetailViewModels()
            {
                department = _departmentrepository.GetDepartment(id??2)
            };
            return View(departmentDetailViewModels);
        }
    }
}
