using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.Models
{
    public class QuotaSocialePagata
    {
        public int Id { get; set; }
        public int Anno { get; set; }
        public DateTime DataPagamento { get; set; }
        public float Quota { get; set; }
        public Persona Persona { get; set; }
    }
}
