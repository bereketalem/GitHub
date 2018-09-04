using System;
using System.ComponentModel.DataAnnotations;

namespace GitHub.Models
{
    public class Gig
    {
        // we wanna make sure that id is not nullable
        [Required]
        public int Id { get; set; }
        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venu { get; set; }

        [Required]
        public Genere Genere { get; set; }
    }
}