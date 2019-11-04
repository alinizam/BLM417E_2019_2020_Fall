using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson6App1.Models;

namespace Lesson6App1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly PersonelDBContext _context;

        public EmployeesController(PersonelDBContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            //var personelDBContext = _context.Employees.Include(e => e.Job);
            var personelDBContext = from emp in _context.Employees
                                    join job in _context.Jobs on emp.JobId equals job.JobId
                                    select new Employees{
                                        PersonelId=emp.PersonelId,
                                        FirstName=emp.FirstName,
                                        LastName=emp.LastName,
                                        JobId=emp.JobId,
                                        Salary=emp.Salary,
                                        DepartmentId=emp.DepartmentId,
                                        Job=new Jobs { JobId=job.JobId,
                                                       JobTitle=job.JobTitle}
                                    };
            return View(await personelDBContext.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.Job)
                .FirstOrDefaultAsync(m => m.PersonelId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonelId,FirstName,LastName,Salary,DepartmentId,JobId")] Employees employees)
        {
            if (ModelState.IsValid)
            {
                var employee = await _context.Employees.FindAsync(employees.PersonelId);
                if (employee != null) {
                    _context.Entry(employee).State = EntityState.Detached;
                    _context.Entry(employees).State = EntityState.Modified;
                    _context.Update(employees);
                   
                }else{
                    _context.Add(employees);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", employees.JobId);
            return View(employees);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees == null)
            {
                return NotFound();
            }
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", employees.JobId);
            return View(employees);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonelId,FirstName,LastName,Salary,DepartmentId,JobId")] Employees employees)
        {
            if (id != employees.PersonelId)
            {
                return NotFound();
            }

            var employee = _context.Employees
                          .Where(x => x.PersonelId == id)
                          .FirstOrDefault();
            _context.Entry(employee).State = EntityState.Detached;
            if (employees.DepartmentId != employee.DepartmentId)
            {
                DepartmentHistory deptHist = new DepartmentHistory();
                deptHist.DepartmentId = employee.DepartmentId;
                deptHist.PersonelId = employee.PersonelId;
                _context.DepartmentHistory.Add(deptHist);
            }
             
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employees);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesExists(employees.PersonelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["JobId"] = new SelectList(_context.Jobs, "JobId", "JobId", employees.JobId);
            return View(employees);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees
                .Include(e => e.Job)
                .FirstOrDefaultAsync(m => m.PersonelId == id);
            if (employees == null)
            {
                return NotFound();
            }

            return View(employees);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employees = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employees);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesExists(int id)
        {
            return _context.Employees.Any(e => e.PersonelId == id);
        }
    }
}
