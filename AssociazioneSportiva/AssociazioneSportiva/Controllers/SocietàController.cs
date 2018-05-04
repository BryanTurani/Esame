using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssociazioneSportiva.Models;
using AssociazioneSportiva.ViewModels;
using System.IO;
using AssociazioneSportiva.Helpers;

namespace AssociazioneSportiva.Controllers
{
    public class SocietàController : Controller
    {
        private IRepository<Società> _repository;

        // Dependency Injection
        // Inietto un'istanza di IRepository<SuperHero>
        // da fuori.
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

            if (model.Id == 0)
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
                $"Aggiunta società '{model.Nome}'";

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

        //[HttpPost]
        //public void ExportToExcel(SociFilterViewModel vm)
        //{
        //    IEnumerable<SociFilterViewModel> visits = getFilteredSoci(vm);

        //    var filename = "Lista soci-" + DateTime.Now.ToString();

        //    var package = ExportHelpers.ToExcel(visits, filename);

        //    using (var memoryStream = new MemoryStream())
        //    {
        //        package.SaveAs(memoryStream);
        //        Response.ContentType = ExportHelpers.ExcelContentType;
        //        Response.AddHeader("content-disposition", "attachment;  filename=" + filename + ".xlsx");
        //        memoryStream.WriteTo(Response.OutputStream);
        //        Response.Flush();
        //        Response.End();
        //    }
        //}

        //private IEnumerable<SociFilterViewModel> getFilteredSoci(SociFilterViewModel vm)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
