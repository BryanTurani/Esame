using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("* Descrizione categoria: ")]
        public string Descrizione { get; set; }

        [Required]
        [DisplayName("* Età minima: ")]
        public int EtàMin { get; set; }

        [Required]
        [DisplayName("* Età massima: ")]
        public int EtàMax { get; set; }
    }
}
