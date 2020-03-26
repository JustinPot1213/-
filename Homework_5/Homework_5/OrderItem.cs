using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class OrderItem
    {
        public Item ThisItem { get; set; }
        public int Num { get; set; }
        private double sumOfPrice;

        public OrderItem(Item item,int num)
        {
            ThisItem = item;
            Num = num;
            sumOfPrice = item.Price * num;
        }

        public override string ToString()
        {
            return ThisItem.ToString() + " *" + Num + "共计￥" + sumOfPrice + "\n";
        }

        public override bool Equals(object obj)
        {
            OrderItem temp = obj as OrderItem;
            return temp != null && temp.ThisItem == this.ThisItem;
        }

        public override int GetHashCode()
        {
            var hashCode = -65958205;
            hashCode = hashCode * -1521134295 + EqualityComparer<Item>.Default.GetHashCode(ThisItem);
            hashCode = hashCode * -1521134295 + Num.GetHashCode();
            hashCode = hashCode * -1521134295 + sumOfPrice.GetHashCode();
            return hashCode;
        }
    }
}
