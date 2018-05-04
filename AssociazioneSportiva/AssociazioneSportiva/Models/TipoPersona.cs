using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class TipoPersona
    {
        public int Id { get; set; }

        /*public string Tipo { get; set; }*/

        public List<SelectListItem> Tipo { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Dirigente" },
            new SelectListItem { Value = "2", Text = "Socio non tesserato" },
            new SelectListItem { Value = "3", Text = "Socio tesserato" },
            new SelectListItem { Value = "4", Text = "Atleta" },
            new SelectListItem { Value = "5", Text = "Altro" },
        };
    }
}
