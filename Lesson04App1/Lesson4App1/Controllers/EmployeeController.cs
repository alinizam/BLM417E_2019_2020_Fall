using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson4App1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson4App1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        private EmployeeDBContext _context;
        public EmployeeController(EmployeeDBContext context) {

            _context = context;
        }
        public IActionResult Index()
        {

            var employeeList=_context.Employees.ToList();
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return View();
        }
        
        public IActionResult Delete(int employeeId)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.PersonelId == employeeId);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
