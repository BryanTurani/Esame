using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Controllers
{
    public class PersonaController
    {
        private IRepository<Persona> _repository;

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newGuest = Guest.Map(model);
                ctx.Guests.Add(newGuest);

                ctx.Visits.Add(new Visit
                {
                    GuestId = newGuest.Id,
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
