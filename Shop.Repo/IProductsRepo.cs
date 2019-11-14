using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Repo
{
    public interface IProductsRepo
    {
        Task<IList<Model.Products.Product>> GetProductsAsync();
        IList<Model.Employees.Employee> GetProducts();
    }
}
