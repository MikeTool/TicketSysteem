﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Applicatie
    {

        public int Id { get; set; }

        public string Naam { get; set; }

        [ForeignKey("Beheerder")]
        public int BeheerderId { get; set; }

        public Mederwerker Beheerder { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
