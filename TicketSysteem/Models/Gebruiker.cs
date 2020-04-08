using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSysteem.Models
{
    public class Gebruiker
    {
        /// <summary>
        /// Primary key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Voornaam (verplicht)
        /// </summary>
        [Required]
        public string Voornaam { get; set; }

        /// <summary>
        /// Tussenvoegsels, zoals "van der"
        /// </summary>
        public string Tussenvoegsels { get; set; }

        /// <summary>
        /// Achternaam (verplicht)
        /// </summary>
        [Required]
        public string Achternaam { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAdres { get; set; }

        public string Telefoonnummer { get; set; }

        [NotMapped]
        public string VolledigeNaam => $"{Voornaam} {Tussenvoegsels} {Achternaam}";
    }
}