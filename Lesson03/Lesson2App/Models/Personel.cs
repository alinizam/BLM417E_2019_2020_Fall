using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson3App.Model
{
    public class Personel
    {
        public static List<Personel> PersonelList = new List<Personel>();
        public int PersonelId { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }

    }
}
