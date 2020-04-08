using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        public string Naam { get; set; }


        public int Volgorde { get; set; }
    }
}
