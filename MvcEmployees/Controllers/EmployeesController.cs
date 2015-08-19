using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEmployees.Models;

namespace MvcEmployees.Controllers
{
    public class EmployeesController : Controller
    {
        //
        // GET: /Employees/

        public ActionResult Index()
        {
            VisitCounter.Counter++;
            return View();
        }

        //
        // GET: /Employees/Details/5

        public ActionResult Details(string id)
        {
            Employee employee = Employee.GetEmployee(id);
            return View(employee);
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(UserViewModel userModel)
        {
            try
            {
                // TODO: Add insert logic here
               // Employee employee = new Employee(employeeModel);
               // Employee.Add(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult List()
        {
            return View(Employee.GetEmployees());
        }

        //
        // GET: /Employees/Create

        public ActionResult Create()
        {
            List<string> StatesList=new List<string>(new string[]{"Tamil Nadu","Kerala","Kolkata"});
            List<string> CitiesList = new List<string>(new string[] { "Chennai", "Cochin", "Calcutta" });
            return View(new EmployeeDetailsViewModel(StatesList,CitiesList));
        } 

        //
        // POST: /Employees/Create

        [HttpPost]
        public ActionResult Create(EmployeeDetailsViewModel employeeModel)
        {
            try
            {
                // TODO: Add insert logic here
                Employee employee = new Employee(employeeModel);
                Employee.Add(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Employees/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employees/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
