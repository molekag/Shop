
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public interface IProductGenerator
    {
        List<DTO.Products.Product> GenerateList();
        Task<List<DTO.Products.Product>> GenerateListAsync();

    }
}
