using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class Tessera
    {
        [Required]
        [DisplayName("* Numero della tessera: ")]
        public int NumeroTessera { get; set; }

        [Range(typeof(DateTime), "1/1/1800", "1/1/2018")]
        [DisplayName("* Data di rilascio: ")]
        public DateTime DataRilascio { get; set; }

        [Required]
        [DisplayName("* Categoria di appartenenza: ")]
        public Categoria Categoria { get; set; }

        [Required]
        [DisplayName("* Persona: ")]
        public Persona Persona { get; set; }
    }
}
