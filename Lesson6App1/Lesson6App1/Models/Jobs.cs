using System;
using System.Collections.Generic;

namespace Lesson6App1.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            Employees = new HashSet<Employees>();
        }

        public int JobId { get; set; }
        public string JobTitle { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
