using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Core;
using Shop.Repo;
using Shop.UI.ViewModel.Products;

namespace Shop.UI.Controllers
{
    public class ProductsController : Controller
    {
        private Shop.Core.IProductGenerator _productGenerator;
        private Shop.Repo.IProductRepo _productRepo;

        public ProductsController(IProductGenerator productGenerator)
        {
            _productRepo = new ProductRepo();

            _productGenerator = new ProductGenerator("domena", _productRepo);
        }



        public async Task<IActionResult> ShowProducts()
        {
            ShowProductsViewModel viewModel = new ShowProductsViewModel();

            viewModel.Products = await _productGenerator.GenerateListAsync();
            viewModel.CurrentTime = DateTime.UtcNow;


            return View(viewModel);

        }
    }
}