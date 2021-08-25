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
    public class EmpDetailController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmpDetailController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<EmployeeDetails> EmployeeList = _db.EmployeeInfo;

            return View(EmployeeList);
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> MyDept  = _db.DepartmentInfo.Select(x =>
                 new SelectListItem
                 {
                     Text = x.Id.ToString(),
                     Value = x.Id.ToString()
                 });

            ViewBag.myDropdown = MyDept;
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeDetails objEmp)
        {
            if(ModelState.IsValid)
            {
                _db.EmployeeInfo.Add(objEmp);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(objEmp);
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objBook = _db.EmployeeInfo.FirstOrDefault(x => x.Id == id);
            if (objBook == null)
            {
                return NotFound();
            }

            return View(objBook);

        }

        [HttpPost]
        public IActionResult Update(EmployeeDetails objBook)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeInfo.Update(objBook);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objBook);

        }

        public IActionResult Delete(int? id)
        {
            var objBook = _db.EmployeeInfo.Find(id);
            if (objBook == null)
            {
                return NotFound();
            }

            _db.EmployeeInfo.Remove(objBook);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
