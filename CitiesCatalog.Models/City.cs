using CitiesCatalog.Models.Abstract;

namespace CitiesCatalog.Models
{
    public class City: Entity
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}