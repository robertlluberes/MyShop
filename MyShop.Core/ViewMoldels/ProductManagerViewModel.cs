using MyShop.Core.Models;
using System.Collections.Generic;

namespace MyShop.Core.ViewMoldels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
