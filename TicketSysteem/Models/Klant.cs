using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Klant : Gebruiker
    {
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
