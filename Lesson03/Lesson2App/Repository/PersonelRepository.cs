using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson3App.Model;

namespace Lesson3App.Repository
{
    public class PersonelRepository : IPersonelRepository
    {
       static public List<Personel> personelList;
       public PersonelRepository() {
            personelList = new List<Personel>()
            {
                new Personel(){PersonelId=1, FirstName="Ahmet",LastName="Ak" },
                new Personel(){PersonelId=2, FirstName="Ayşe",LastName="Ak" },
                new Personel(){PersonelId=3, FirstName="Mehmet",LastName="Ak" }
            };
        }

        public void addPersonel(Personel personel)
        {
            personelList.Add(personel);
        }

        public List<Personel> getPersonelList()
        {
            return personelList;
        }

        public Personel getPersonelById(int id)
        {
            return personelList.FirstOrDefault(p => (p.PersonelId == id));
        }
    }
}
