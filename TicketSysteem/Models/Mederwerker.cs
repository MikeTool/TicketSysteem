using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Mederwerker : Gebruiker
    {
        public ICollection<Applicatie> Applicaties { get; set; }
    }
}
