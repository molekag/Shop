﻿using Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration.ViewModels.Order
{
    public class ListOrderViewModel
    {
        public List<Delivery> Orders { get; set; }
        public DateTime ProduceDate { get; set; }

        DateTime date = new DateTime(2019, 12, 02);
        

    }
}
