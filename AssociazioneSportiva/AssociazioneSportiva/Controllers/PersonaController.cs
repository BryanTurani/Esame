using AssociazioneSportiva.DataAccess;
using AssociazioneSportiva.Models;
using AssociazioneSportiva.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Controllers
{
    public class PersonaController : Controller
    {
        private IRepository<Persona> _repository;

        public PersonaController(IRepository<Persona> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var models = _repository.FindAll();

            return View(models);
        }
        public IActionResult Registration()
        {
            return View();
        }


        public ActionResult SuccedeedSave()
        {
            return View();
        }
    }
}
