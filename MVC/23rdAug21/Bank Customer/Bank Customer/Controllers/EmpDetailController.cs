using Bank_Customer.Data;
using Bank_Customer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_Customer.Controllers
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
            IEnumerable<CustomerDetails> CustomerList = _db.UserDetails;

            return View(CustomerList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerDetails objBook)
        {
            if (ModelState.IsValid)
            {
                _db.UserDetails.Add(objBook);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(objBook);

        }

    }
}
