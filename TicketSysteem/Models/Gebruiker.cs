using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteem.Models
{
    /// <summary>
    /// Model voor een docent die vakken geeft
    /// </summary>
    public class Gebruiker
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Voornaam (verplicht)
        /// </summary>
        [Required]
        public string Naam { get; set; }

        /// <summary>
        /// Tussenvoegsels, zoals "van der"
        /// </summary>
        public string Tussenvoegsels { get; set; }

        /// <summary>
        /// Achternaam (verplicht)
        /// </summary>
        [Required]
        public string Achternaam { get; set; }

        public string Emailadres { get; set; }

        public string Telefoonnummer { get; set; }
    }
}