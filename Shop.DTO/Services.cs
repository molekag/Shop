using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DTO
{
    class Services
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public DateTime ValidTill { get; set; }
        public List<DTO.Products.Product> ProductCertifed { get; set; }
    }
}
