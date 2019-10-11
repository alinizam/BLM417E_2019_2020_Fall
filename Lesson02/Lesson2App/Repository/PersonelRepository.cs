using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson2App.Model;

namespace Lesson2App.Repository
{
    public class PersonelRepository : IPersonelRepository
    {
       List<Personel> personelList;
       public PersonelRepository() {
            personelList = new List<Personel>()
            {
                new Personel(){PersonelId=1, FirstName="Ahmet",LastName="Ak" },
                new Personel(){PersonelId=2, FirstName="Ayşe",LastName="Ak" },
                new Personel(){PersonelId=3, FirstName="Mehmet",LastName="Ak" }
            };
        }
        public Personel getPersonelById(int id)
        {
            return personelList.FirstOrDefault(p => (p.PersonelId == id));
        }
    }
}
