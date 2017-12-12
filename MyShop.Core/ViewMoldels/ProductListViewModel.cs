using MyShop.Core.Models;
using System.Collections.Generic;

namespace MyShop.Core.ViewMoldels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
