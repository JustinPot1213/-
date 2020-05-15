using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework_5
{
    [Serializable]
    public class OrderItem
    {
        [XmlElement(Type = typeof(Item))]
        public Item ThisItem { get; set; }
        [XmlAttribute]
        public int Num { get; set; }
        [XmlAttribute]
        public double SumOfPrice { get; set; }

        public int OrderItemId { get; set; }
        public ICollection<Order> Orders { get; set; }

        public OrderItem() { }

        public OrderItem(Item item,int num)
        {
            ThisItem = item;
            Num = num;
            SumOfPrice = item.Price * num;
            //this.OrderItemId = GetHashCode();
        }

        public override string ToString()
        {
            return ThisItem.ToString() + " *" + Num + "共计￥" + SumOfPrice + "\n";
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
            hashCode = hashCode * -1521134295 + SumOfPrice.GetHashCode();
            return hashCode;
        }
    }
}
