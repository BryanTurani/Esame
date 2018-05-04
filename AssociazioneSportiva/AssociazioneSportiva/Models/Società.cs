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
        public int IdSocietà { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Partita IVA: ")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "La partita IVA deve avere 11 caratteri!")]
        public int PartitaIva { get; set; }
        
        [DisplayName("* Codice fiscale: ")]
        public string CodFiscaleSoc { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Indirizzo: ")]
        public string Indirizzo { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Numero civico: ")]
        public int NumCivico { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Città: ")]
        public string Città { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Paese: ")]
        public string Paese { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Tipo di società: ")]
        public List<TipoSocietà> TipoSocietà { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Indirizzo eMail: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Indirizzo eMail certificato: ")]
        public string EmailCertificata { get; set; }

        [Required(ErrorMessage = "Campo obbligatorio")]
        [DisplayName("* Lista persone: ")]
        public List<Persona> Persone { get; set; }
    }
}
