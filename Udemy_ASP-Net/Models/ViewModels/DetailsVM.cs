using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy_ASP_Net.Models.ViewModels
{
    public class DetailsVM
    {
        public Product Product{ get; set; }

        public bool ExistsInCart { get; set; }

        public DetailsVM()
        {
            Product = new Product();
        }
    }
}
