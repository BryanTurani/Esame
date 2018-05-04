using System;
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
        public int Id { get; set; }

        [Required]
        [DisplayName("* Nome: ")]
        public string Nome { get; set; }

        [Required]
        [DisplayName("* Cognome: ")]
        public string Cognome { get; set; }

        [Required]
        [DisplayName("* Codice Fiscale: ")]
        public string CodFiscalePers { get; set; }

        [Range(typeof(DateTime), "1/1/1800", "1/1/2018")]
        [DisplayName("* Data di nascita: ")]
        public DateTime DataDiNascita { get; set; }

        [Required]
        [DisplayName("* Città Natale: ")]
        public string LuogoDiNascita { get; set; }

        [Required]
        [DisplayName("* Indirizzo: ")]
        public string Indirizzo { get; set; }

        [Required]
        [DisplayName("* Numero civico: ")]
        public int NumCivico { get; set; }

        [Required]
        [DisplayName("* Residenza: ")]
        public string Residenza { get; set; }

        [Required]
        [DisplayName("* Paese: ")]
        public string Paese { get; set; }

        [Required]
        [DisplayName("* Numero di telefono: ")]
        public int Telefono { get; set; }

        [Required]
        [DisplayName("* Indirizzo e-mail: ")]
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
