using AssociazioneSportiva.DataAccess;
using AssociazioneSportiva.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Controllers
{
    public class TesseraController : Controller
    {
        private IRepository<Tessera> _repository;

        public TesseraController(IRepository<Tessera> repository)
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
            Tessera model;

            if (id == 0)
            {
                model = new Tessera();
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
        public IActionResult Edit(Tessera model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.NumeroTessera == 0)
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
                $"Modificata tessera '{model.NumeroTessera}'";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _repository.Find(id);

            if (model == null)
                return NotFound();

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Tessera model)
        {
            var success = _repository.Delete(model);

            if (!success)
                return NotFound();

            TempData["message"] = $"Rimossa tessera {model.NumeroTessera}";

            return RedirectToAction(nameof(Index));
        }
    }
}
