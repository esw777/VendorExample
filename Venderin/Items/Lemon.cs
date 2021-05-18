using System;
using System.Collections.Generic;
using System.Text;

namespace Vendering.Items
{
    public class Lemon : Item
    {
        public string Name { get => "Lemon"; }
        public double Price { get => 24.2; }
        public ItemCategory Category { get => ItemCategory.Other; }
    }
}
