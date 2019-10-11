
using Lesson3App.Model;
using Lesson3App.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson3App.Controllers
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
        
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AnotherPage()
        {
            return View();
        }
        [HttpGet]
        public ViewResult List() {
            ViewData["MyPageName"] = "It is my ViewDataPage";
            ViewData["myPersonel"] = new Personel()
            {
                PersonelId = 105,
                FirstName = "Ahmet",
                LastName = "Ak"
            };
            return View();
        }

        public ViewResult PageForViewBag()
        {
            ViewBag.MyPageName = "My First View Bag Example";
            ViewBag.person = new Personel()
            {
                PersonelId = 105,
                FirstName = "Ahmet",
                LastName = "Ak"
            };


            return View();
        }


        [HttpPost]
        
        public ViewResult Create([Bind("PersonelId,FirstName,LastName")] Personel model)
        {
            Console.WriteLine(ModelState);
            ViewData["SayfaIsmi"] = Request.Form["FirstName"];
            return View("Create", model);
        }


        public ViewResult AnotherPage([Bind("PersonelId,FirstName,LastName")] Personel model)
        {
            return View("AnotherPage", model);
        }

        [HttpPost]
        public ViewResult Add(Personel person) {
            _repository.addPersonel(person);
            ViewBag.PersonelList=_repository.getPersonelList();
            return View(); 
        }
        
        public ViewResult Add() {
            ViewBag.PersonelList = _repository.getPersonelList();
            return View();
        }
        /*public IActionResult Index(int id) {
            IPersonelRepository _repository=new PersonelRepository();
            Personel personel=_repository.getPersonelById(id);
            return View(personel);
        }*/
    }
}
