using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Model.Products
{
    public class Product /// Zeby klasa byla dostepna poza namespace / klasa musi miec access modifier (typu public). Class bez public nie jest dostepny poza Shop.Model.Products
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
