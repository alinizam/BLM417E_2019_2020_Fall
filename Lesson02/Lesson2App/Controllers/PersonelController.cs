
using Lesson2App.Model;
using Lesson2App.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson2App.Controllers
{
    public class PersonelController:Controller
    {
        private IPersonelRepository _repository;

        public PersonelController(IPersonelRepository repository) {
            _repository = repository;
        }

        public IActionResult Index(int id)
        {
             
            Personel personel = _repository.getPersonelById(id);
            return View(personel);
        }

        /*public IActionResult Index(int id) {
            IPersonelRepository _repository=new PersonelRepository();
            Personel personel=_repository.getPersonelById(id);
            return View(personel);
        }*/
    }
}
