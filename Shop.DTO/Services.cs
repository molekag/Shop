using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DTO
{
    public class Services //public jesli ma byc dostepne poza tym projektem/klasa bez dziedziczenia
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public DateTime ValidTill { get; set; }
        public List<DTO.Products.Product> ProductCertifed { get; set; }
    }
}
