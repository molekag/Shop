using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repo
{
    public interface IProductRepo
    {
        Task<IList<Model.Products.Product>> GetProductsAsync(); //Brakowalo reference do projektu Shop.Model
        IList<Model.Products.Product> GetProducts(); // IList<Model.Employees.Employee> GetProducts();  //Poki co model.employees.employee nie istnieje
    }
}
