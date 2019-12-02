using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using Registration.ViewModels.Order;

namespace Registration.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListOrder()
        {
            List<Delivery> order = new List<Delivery>();

            order.Add(new Delivery { DeliveryID = "0", DateTime = "20:30,12.12.2019", DeliveryAddress = "1 abc, Alphabet"});
            order.Add(new Delivery { DeliveryID = "1", DateTime = "10:30,13.12.2019", DeliveryAddress = "2 Unknown, Somewhere 13-300" });
            order.Add(new Delivery { DeliveryID = "3", DateTime = "11:15,14.12.2019", DeliveryAddress = "13 Badluck, Hell" });

            ListOrderViewModel viewModel = new ListOrderViewModel();

            DateTime date = default(DateTime);
           
       
            return View(viewModel);
                
                
        }
            



    }
}