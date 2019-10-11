using Lesson3App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson3App.Repository
{
    public interface IPersonelRepository
    {
        Personel getPersonelById(int id);
        void addPersonel(Personel personel);
        List<Personel> getPersonelList();

    }
}
