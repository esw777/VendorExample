using System;
using System.Collections.Generic;
using System.Text;

namespace Vendering.Items
{
    public class PepsiMax : Item
    {
        public string Name { get => "PepsiMax"; }
        public double Price { get => 24.2; }
        public ItemCategory Category { get => ItemCategory.Beverage; }
    }
}
