using Brandlist_Export_Assistant.Enums;

namespace Brandlist_Export_Assistant.Classes
{
    public class SubBrand : Brand
    {
        public ProductType Type { get; set; }

        public bool HasMainBrand { get; set; }
    }
}
