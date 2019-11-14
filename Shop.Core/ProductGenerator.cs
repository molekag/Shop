using Shop.DTO.Products;
using Shop.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public class ProductGenerator : IProductGenerator
    {
        private string _domain;
        private IProductsRepo _productRepo;

        public ProductGenerator(string domain, IProductsRepo productsRepo)
        {
            _productRepo = productsRepo;
            _domain = domain;
        }

        public List<Product> GenerateList()
        {
            var products = _productRepo.GetProducts();
            var productList = new _List<DTO.Products.Product>();

            foreach (Model.Products.Product sofa in products)
            {
                productList.Add(ProcessProduct(sofa));
            }


            return productList;

        } 
    