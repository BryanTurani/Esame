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

        [HttpPost]
        public IActionResult Registration(SociFilterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var nuovoSocio = Socio.Map(model);
                ctx.Socio.Add(nuovoSocio);

                ctx.Registazione.Add(new Registrazione
                {
                    SocioId = newGuest.Id,
                    Registration = DateTime.Now,
                    VisitedPerson = model.VisitedPerson,
                    MotivationId = Convert.ToInt32(model.Motivation),
                    AreaId = Convert.ToInt32(model.Area),
                    VisitStateId = (int)VisitStatus.Registered
                });
                ctx.SaveChanges();
                return RedirectToAction(nameof(SuccedeedSave));
            }
            return View();
        }

        public ActionResult SuccedeedSave()
        {
            return View();
        }
    }
}
