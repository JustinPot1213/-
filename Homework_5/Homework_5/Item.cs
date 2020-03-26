using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }

        public Item(string itemName,double price)
        {
            this.Name = itemName;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Name + " ￥" + Price.ToString();
        }
    }
}
