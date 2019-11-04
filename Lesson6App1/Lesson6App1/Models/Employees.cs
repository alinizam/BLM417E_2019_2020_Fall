using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson6App1.Models
{
    public partial class Employees
    {
        [Required]
        public int PersonelId { get; set; }

        [StringLength(10)]
        [MinLength(3)]

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Range (2000,1000000)]
        public int? Salary { get; set; }
        public int DepartmentId { get; set; }
        public int? JobId { get; set; }

        public Jobs Job { get; set; }
    }
}
