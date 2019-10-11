using Lesson2App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2App.Repository
{
    public interface IPersonelRepository
    {
        Personel getPersonelById(int id);
    }
}
