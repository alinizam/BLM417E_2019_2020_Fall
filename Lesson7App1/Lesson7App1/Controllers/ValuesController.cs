using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson7App1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson7App1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly PersonelDBContext _context;
        public ValuesController(PersonelDBContext context) {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employees>> Get()
        {
            return Ok(_context.Employees.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employees> Get(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.PersonelId == id);
            if (employee == null) {
                return NotFound();   
            }
            return employee;

        }

        // GET api/values/5
        [HttpGet("{firstName}/{lastName}")]
        public ActionResult<Employees> Get(string firstName, string lastName)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.FirstName.StartsWith(firstName) && e.LastName.StartsWith(lastName));
            if (employee == null)
            {
                return NotFound();
            }
            return employee;

        }

        // GET api/values/5
        [HttpGet("{firstName}")]
        public ActionResult<Employees> Get(string firstName)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.FirstName.StartsWith(firstName));
            if (employee == null)
            {
                return NotFound();
            }
            return employee;

        }
        [Route("[action]/{firstName}")]
        [HttpGet]
        public ActionResult<Employees> GetByName(string firstName)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.FirstName.StartsWith(firstName));
            if (employee == null)
            {
                return NotFound();
            }
            return employee;

        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Employees employee)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            _context.Add(employee);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Employees employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Update(employee);
            _context.SaveChanges();
            return Ok();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.PersonelId == id);
            if (employee == null) {
                return NotFound();
            }
            _context.Remove(employee);
            _context.SaveChanges();
            return Ok(); 
        }
    }
}
