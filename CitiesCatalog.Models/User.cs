using CitiesCatalog.Models.Abstract;

namespace CitiesCatalog.Models
{
    public class User: Entity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public City City { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
