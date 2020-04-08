using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Klant")]
        [Required]
        public int KlantId { get; set; }

        public Klant Klant { get; set; }

        [ForeignKey("Applicatie")]
        [Required]
        public int ApplicatieId { get; set; }

        public Applicatie Applicatie { get; set; }

        [Required]
        [StringLength(60)]
        public string Onderwerp { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Omschrijving { get; set; }

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }




    }
}
