using System;
using System.Collections.Generic;
using System.Text;
using Vendering.Items;

namespace Vendering
{
    public class Customer
    {
        private double money = 100;
        public double Money { get { return money; } set { money = value; } }

        public List<Item> customerInventoryList = new List<Item>();

    }
}
