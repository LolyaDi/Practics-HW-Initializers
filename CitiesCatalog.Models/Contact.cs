using CitiesCatalog.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CitiesCatalog.Models
{
    public class Contact: Entity
    {
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        [MaxLength(13)]
        public string TelephoneNumber { get; set; }
    }
}
