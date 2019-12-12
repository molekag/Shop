using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.UI.ViewModel.Products
{
    public class ShowProductsViewModel
    {
        public List<DTO.Products.Product> Products { get; set; }
        public DateTime CurrentTime { get; set; }
    }
}
