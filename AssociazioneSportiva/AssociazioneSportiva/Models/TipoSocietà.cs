using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class TipoSocietà
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tipo società")]
        public string Tipo { get; set; }
    }
}
