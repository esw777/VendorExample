using System;
using System.Collections.Generic;
using System.Text;

namespace Vendering.Items
{
    public class ChocolateBar : Item
    {
        public string Name { get => "ChocolateBar"; }
        public double Price { get => 24.2; }
        public ItemCategory Category { get => ItemCategory.Candy; }
    }
}
