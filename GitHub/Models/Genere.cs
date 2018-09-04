using System.ComponentModel.DataAnnotations;

namespace GitHub.Models
{
    public class Genere
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}