using System;
using System.Collections.Generic;
using System.Text;

namespace Vendering.Items
{
    public class CocaCola : Item
    {
        public string Name { get => "CocaCola"; }
        public double Price { get => 24.2; }
        public ItemCategory Category { get => ItemCategory.Beverage; }
    }
}
