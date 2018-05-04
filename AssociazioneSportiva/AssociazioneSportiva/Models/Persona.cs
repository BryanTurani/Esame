﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AssociazioneSportiva.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }

        [Required]
        [DisplayName("* Nome: ")]
        public string Nome { get; set; }

        [Required]
        [DisplayName("* Cognome: ")]
        public string Cognome { get; set; }

        [Required]
        [DisplayName("* Codice Fiscale: ")]
        public string CodFiscalePersona { get; set; }

        [DisplayName("* Data di nascita: ")]
        [Range(typeof(DateTime), "1/1/1800", "1/1/2018")]
        public DateTime DataDiNascita { get; set; }

        [Required]
        [DisplayName("* Luogo di nascita: ")]
        public string LuogoDiNascita { get; set; }

        [Required]
        [DisplayName("* Paese: ")]
        public string Paese { get; set; }

        [Required]
        [DisplayName("* Indirizzo: ")]
        public string Indirizzo { get; set; }

        [Required]
        [DisplayName("* Numero civico: ")]
        public int NumeroCivico { get; set; }

        [Required]
        [DisplayName("* Numero di telefono: ")]
        public int Telefono { get; set; }

        [Required]
        [DisplayName("* Indirizzo eMail: ")]
        public string Email { get; set; }

        [Required]
        [DisplayName("* Fototessera(3.5 x 4.5 cm): ")]
        public byte[] Foto { get; set; }

        [Required]
        [DisplayName("* Tipologia di persona: ")]
        public TipoPersona Tipologia { get; set; }

        [Required]
        [DisplayName("* Lista delle quote sociali pagate: ")]
        public List<QuotaSocialePagata> QuoteSocialiPagate { get; set; }
    }

}
