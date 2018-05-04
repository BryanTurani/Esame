using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class Società
    {
        [Required]
        [DisplayName("* Nome della società: ")]
        public string Nome { get; set; }

        [Required]
        [DisplayName("* Codice della società: ")]
        public int Id { get; set; }

        [Required]
        [DisplayName("* Tipo di società: ")]
        public List<TipoSocietà> Tipo { get; set; }

        [Required]
        [DisplayName("* Partita IVA: ")]
        public int PartitaIva { get; set; }

        [Required]
        [DisplayName("* CodiceFiscale della società: ")]
        public int CodFiscaleSoc { get; set; }

        [Required]
        [DisplayName("* Indirizzo: ")]
        public string Indirizzo { get; set; }

        [Required]
        [DisplayName("* Numero civico: ")]
        public int NumCivico { get; set; }

        [Required]
        [DisplayName("* Città: ")]
        public string Città { get; set; }

        [Required]
        [DisplayName("* Paese: ")]
        public string Paese { get; set; }

        [Required]
        [DisplayName("* Indirizzo e-mail: ")]
        public string Email { get; set; }

        [Required]
        [DisplayName("* e-mail certificata: ")]
        public string EmailCertificata { get; set; }

        [Required]
        [DisplayName("* Lista persone: ")]
        public List<Persona> Persone { get; set; }
    }
}
