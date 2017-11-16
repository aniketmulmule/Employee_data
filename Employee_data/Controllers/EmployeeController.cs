using Employee_data.Models;
using Employee_data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Employee_data.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        private ApplicationDbContext _context;

        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New_Employee()
        {

            var viewModel = new EmployeeFormViewModel
            {
                Employee = new Employee(),
            };

            return View("New_Employee", viewModel);
            //return View("New");
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
          //  Response.Write("Data inserted successfully");
            return RedirectToAction("Index", "Home");
        }

    }
}