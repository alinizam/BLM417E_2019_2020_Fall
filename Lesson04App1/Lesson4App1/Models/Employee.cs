using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lesson4App1.Models
{
    public class Employee
    {
        [Key]
        public int PersonelId{ get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public int Salary{ get; set; }
    }
}
