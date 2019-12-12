using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.Repo
{
    public class ProductRepo : IProductRepo // nazwy zmienione do liczby pojedynczej. Bo kazda klasa jest pojedyncza, tylko obiekt moze byc mnoga jesli to jakiejs formy lista

    {

        public async Task<IList<Model.Products.Product>> GetProductsAsync()
        {

            List<Model.Products.Product> products = new List<Model.Products.Product>();
            Model.Products.Product product = new Model.Products.Product()
            {
                Name = "Sofa",
                Description = "Black",
                Price = 200,
            };

            Model.Products.Product product2 = new Model.Products.Product()
            {
                Name = "Table",
                Description = "Glass",
                Price = 150,
            };

            products.Add(product);
            products.Add(product2);

            return products;
        }

        public IList<Model.Products.Product> GetProducts()
        {
            List<Model.Products.Product> products = new List<Model.Products.Product>();
            Model.Products.Product product = new Model.Products.Product()
            {
               Name = "Sofa",
               Description = "Black",
               Price = 200,
            };
            Model.Products.Product product2 = new Model.Products.Product()
            {
                Name = "Table",
                Description = "Glass",
                Price = 150,

            };
            return products;


        }



        //musisz dodac teraz implementacje dla GetProducts i dodac to w IProductRepo (teraz jest skomentowane)
        //
    }
}
