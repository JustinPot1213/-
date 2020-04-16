using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_5
{
    [Serializable]
    public class Order
    {
        [XmlArray]
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        [XmlElement(Type = typeof(Buyer))]
        public Buyer OrderBuyer { get; set; }
        [XmlAttribute]
        public long OrderID { get; set; }
        [XmlAttribute]
        public double SumOfCost { get; set; }

        public Order() { }

        public Order(Buyer buyer, List<OrderItem> orderItems)
        {
            this.OrderBuyer = buyer;
            foreach (OrderItem item in orderItems){
                this.OrderItems.Add(item);
            }
            DateTime n = DateTime.Now;
            OrderID = n.Second+n.Minute*100+n.Hour*100+n.Day*100+n.Month*100;
        }

        public Order(Buyer buyer)
        {
            this.OrderBuyer = buyer;
            DateTime n = DateTime.Now;
            OrderID = n.Millisecond*10 +
                      n.Second * 10000 +
                      n.Minute * 1000000 +
                      n.Hour * 100000000;
            this.SumOfCost = 0;
        }

        public bool AddOrderItem(OrderItem oi)
        {

            foreach (OrderItem item in OrderItems)
            {
                if (item == null) break;
                else if (oi.Equals(item)) return false;
            }
            OrderItems.Add(oi);
            SumOfCost += oi.ThisItem.Price * oi.Num;
            return true;
        }

        public bool DeleteOrderItem(OrderItem oi)
        {
            foreach (OrderItem item in OrderItems)
            {
                if (item == null) break;
                else if (oi.Equals(item))
                {
                    OrderItems.Remove(oi);
                    SumOfCost -= oi.ThisItem.Price * oi.Num;
                    return true;
                }
            }
            
            return false;
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            return temp != null && temp.OrderID == this.OrderID;
        }

        public override string ToString()
        {
            StringBuilder orderStr=new StringBuilder();
            orderStr.Append ("订单号为" + OrderID + "\n" + OrderBuyer.ToString());
            foreach (OrderItem item in OrderItems)
            {
                orderStr.Append("    "+item.ToString());
            }
            orderStr.Append("订单总计花费 ￥" + SumOfCost+"\n\n");
            return orderStr.ToString();
        }

        public override int GetHashCode()
        {
            var hashCode = 574100415;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + EqualityComparer<Buyer>.Default.GetHashCode(OrderBuyer);
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + SumOfCost.GetHashCode();
            return hashCode;
        }
    }
}
