using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Repo
{
    public class ProductsRepo : IProductsRepo

    {
        public async Task<IList<Model.Products.Product>> GetProductsAsync()
            
        {

            List<Model.Products.Product> products = new List<Model.Products.Product>();
            Model.Prodcuts.Product product = new Model.Prodcuts.Product()
            {
                Name = "Sofa",
                Description = "Black",
                Price = 200,
            };

            Model.Prodcuts.Product product2 = new Model.Prodcuts.Product()
            {
                Name = "Table",
                Description = "Glass",
                Price = 150,
            };

            products.Add(product);
            products.Add(product2);

            return products;


    }
}
