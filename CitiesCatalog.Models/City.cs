using CitiesCatalog.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace CitiesCatalog.Models
{
    public class City: Entity
    {
        [Required]
        public int Code { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}