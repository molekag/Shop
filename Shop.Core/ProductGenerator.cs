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
        private IProductRepo _productRepo;

        public ProductGenerator(string domain, IProductRepo productRepo)
        {
            _productRepo = productRepo;
            _domain = domain;
        }

        public List<Product> GenerateList()
        {
            var products =  _productRepo.GetProductsAsync().Result; // jesli uzywasz Async w metodzie sync, to musisz dodac waiter lub result. Ale to w wyjatkowych sytuacjach. Normalnie  dajesz await przed  np await _productRepo.Get
            
            // tu wlasnie bys uzyla _productRepo.GetProducts()

            var productList = new List<DTO.Products.Product>();

            //foreach (Model.Products.Product sofa in products)  // products jest typu IList<Model.EmployeesEmployee> a nie Model.Products.Product, generalnie foreach czy cast musi odbywac sie w tym samym typie. 
            //{
            //    productList.Add(ProcessProduct(sofa));
            //}

            foreach (Model.Products.Product product in products)
            {
                try
                {
                    Random rand = new Random(); // Jako ze product nie zawier Id, to sobie wygenerujemy Id, przydatne bo Shop.Core moze robic jakies obliczenia, wiec normalne ze MOdel moze nie miec jakiegos property
                    //Poza tym mozesz laczyc np. product z zamowieniem i mixowac do DTO ktore jest uzywane gdzie indziej

                    //Random to generator losowych cyfr
                    DTO.Products.Product productDTO = new Product() // tworze nowy obiekt typu DTO.Products.Product
                    {
                        Id = rand.Next(15, 2000), // to wygeneruje loswa cyfre miedzy 15 a 2000

                    };

                    productDTO.Name = product.Name + $" [{productDTO.Id}]";  // Tworze name na podstawie product.name + dodaje [id], wiec bedzie Trash [3]

                    if (productDTO.Id < 500) // jesli id mniejsz niz 500
                        productDTO.Type = "Shoes"; // to productoDTo.Type = Shoes
                    if (productDTO.Id >= 500 && productDTO.Id <= 1500) // jesli id pomiedzy 500 (wliczajac 500) a 15000 (wliczajac 1500) 
                        productDTO.Type = "Monitor"; //To Type = Monitor
                    if (productDTO.Id > 1500) // jesli Id > 1500
                        productDTO.Type = "Trash"; // To produkt to smiec :D

                    productList.Add(productDTO); // teraz mamy obiekt ktory wypelnione ma wszystkie properties, jakas logike, i ten sam typ co productList (nie mozna dodawac dowolnych rzeczy do Listy danego typu. Musi byc ten sam typ
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error {e}");
                    
                }
              

              
                
            }

            return productList;

        }


        public async Task<List<Product>> GenerateListAsync() // dodano async Task
        {
            var products = await _productRepo.GetProductsAsync(); // teraz mozesz uzyc GetProductsAsync z await, bo bez await bedzie obiekt typu Task a nie IList jako rezultat. Await to jakby metoda Task ktora mowi ze ma zwrocic type z metody, a nie Task

            var productList = new List<DTO.Products.Product>();

            //foreach (Model.Products.Product sofa in products)  // products jest typu IList<Model.EmployeesEmployee> a nie Model.Products.Product, generalnie foreach czy cast musi odbywac sie w tym samym typie. 
            //{
            //    productList.Add(ProcessProduct(sofa));
            //}

            foreach (Model.Products.Product product in products)
            {
                try
                {
                    Random rand = new Random(); // Jako ze product nie zawier Id, to sobie wygenerujemy Id, przydatne bo Shop.Core moze robic jakies obliczenia, wiec normalne ze MOdel moze nie miec jakiegos property
                    //Poza tym mozesz laczyc np. product z zamowieniem i mixowac do DTO ktore jest uzywane gdzie indziej

                    //Random to generator losowych cyfr
                    DTO.Products.Product productDTO = new Product() // tworze nowy obiekt typu DTO.Products.Product
                    {
                        Id = rand.Next(15, 2000), // to wygeneruje loswa cyfre miedzy 15 a 2000

                    };

                    productDTO.Name = product.Name + $" [{productDTO.Id}]";  // Tworze name na podstawie product.name + dodaje [id], wiec bedzie Trash [3]

                    if (productDTO.Id < 500) // jesli id mniejsz niz 500
                        productDTO.Type = "Shoes"; // to productoDTo.Type = Shoes
                    if (productDTO.Id >= 500 && productDTO.Id <= 1500) // jesli id pomiedzy 500 (wliczajac 500) a 15000 (wliczajac 1500) 
                        productDTO.Type = "Monitor"; //To Type = Monitor
                    if (productDTO.Id > 1500) // jesli Id > 1500
                        productDTO.Type = "Trash"; // To produkt to smiec :D

                    productList.Add(productDTO); // teraz mamy obiekt ktory wypelnione ma wszystkie properties, jakas logike, i ten sam typ co productList (nie mozna dodawac dowolnych rzeczy do Listy danego typu. Musi byc ten sam typ
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error {e}");

                }




            }

            return productList;
        } 
    