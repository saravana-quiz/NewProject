using Employee_Department_Details.Data;
using Employee_Department_Details.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Department_Details.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DepartmentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<DepartmentDetails> DepartmentList = _db.DepartmentInfo;

            return View(DepartmentList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentDetails objDept)
        {
            if (ModelState.IsValid)
            {
                _db.DepartmentInfo.Add(objDept);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(objDept);
        }
    }
}
