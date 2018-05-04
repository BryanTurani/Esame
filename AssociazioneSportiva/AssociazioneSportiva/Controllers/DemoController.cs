using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssociazioneSportiva.DataAccess;
using AssociazioneSportiva.Models;

namespace AssociazioneSportiva.Controllers
{
    public class DemoController : Controller
    {
        private readonly AppDbContext _context;

        public DemoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Società> listasocietà = new List<Società>();

            // Prendo i dati dal database usando l'EntityFrameworkCore
            listasocietà = (from societa in _context.Società
                            select societa).ToList();

            // Inserisco i dati selezionati all'interno di una lista
            listasocietà.Insert(0, new Società { IdSocietà = 0, Nome = "Select" });

            // Assegno la società alla ViewBag.ListaSocietà
            ViewBag.listadellesocietà = listasocietà;

            return View();
        }
    }
}