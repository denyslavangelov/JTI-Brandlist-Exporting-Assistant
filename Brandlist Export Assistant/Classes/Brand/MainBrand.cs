using System.Collections.Generic;

namespace Brandlist_Export_Assistant.Classes
{
    public class MainBrand : Brand
    {
        public MainBrand()
        {
            SubBrandList = new List<SubBrand>();
        }

        public List<SubBrand> SubBrandList { get; set; }

        public bool HasAnySubBrands { get; set; }

        public void PopulateBrandsWithSubBrands(ExcelProcessor _brandlist, MainBrand brand)
        {
            foreach (var subBrand in _brandlist.SubBrandList)
            {
                if (subBrand.BrandCode.Contains(brand.BrandCode))
                {
                    brand.SubBrandList.Add(subBrand);
                    subBrand.HasMainBrand = true;
                    brand.HasAnySubBrands = true;
                }
            }
        }
    }
}
