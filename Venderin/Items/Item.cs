using System;
using System.Collections.Generic;
using System.Text;

namespace Vendering.Items
{
    public interface Item
    {
        public string Name { get;}
        public double Price { get;}
        public ItemCategory Category { get;}
    }

    public enum ItemCategory
    {
        Beverage,
        Candy,
        Other
    }
}
