using Microsoft.AspNetCore.Mvc;
using AssociazioneSportiva.Models;
using AssociazioneSportiva.DataAccess;

namespace AssociazioneSportiva.Controllers
{
    public class SocietàController : Controller
    {
        private IRepository<Società> _repository;

        public SocietàController(IRepository<Società> repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Società model;

            if (id == 0)
            {
                model = new Società();
            }
            else
            {
                model = _repository.Find(id);

                if (model == null)
                    return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Società model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.IdSocietà == 0)
            {
                _repository.Insert(model);
            }
            else
            {
                var result = _repository.Update(model);
                if (!result)
                    return NotFound();
            }

            TempData["Message"] =
                $"Modificata società '{model.Nome}'";

            return RedirectToAction(nameof(Index));
        }       
    }
}
