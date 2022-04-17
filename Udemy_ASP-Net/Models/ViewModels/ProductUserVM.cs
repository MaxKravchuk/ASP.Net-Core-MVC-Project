using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASP_Net.Models.ViewModels
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            ProductList = new List<Product>();
        }

        public ApplicationUser ApplicationUser { get; set; }

        public IList<Product> ProductList { get; set; }
        
    }
}
