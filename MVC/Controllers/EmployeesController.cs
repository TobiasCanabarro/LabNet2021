using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var logic = new EmployeesLogic();
            List<Entities.Employees> employees = logic.GetAll();

            return View(employees);
        }
    }
}