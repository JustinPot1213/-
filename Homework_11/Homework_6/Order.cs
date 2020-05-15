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
    public class Order
    {
        //[XmlArray]
        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        //[XmlElement(Type = typeof(Buyer))]
        public virtual Buyer Buyer { get; set; }
        //[XmlAttribute]
        public long OrderID { get; set; }
        //[XmlAttribute]
        public double SumOfCost { get; set; }
        public string BuyerName { get; set; }


        public Order() { }

        public Order(Buyer buyer, List<OrderItem> orderItems)
        {
            this.Buyer = buyer;
            this.BuyerName = buyer.BuyerName;
            foreach (OrderItem item in orderItems){
                this.OrderItems.Add(item);
            }
            /*
            DateTime n = DateTime.Now;
            OrderID = n.Millisecond * 10 +
                      n.Second * 10000 +
                      n.Minute * 1000000 +
                      n.Hour * 100000000;
                      */
        }

        public Order(Buyer buyer)
        {
            this.Buyer = buyer;
            this.BuyerName = buyer.BuyerName;
            /*
            DateTime n = DateTime.Now;
            OrderID = n.Millisecond*10 +
                      n.Second * 10000 +
                      n.Minute * 1000000 +
                      n.Hour * 100000000;
                      */
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
            using (var db = new OrderContext())
            {
                StringBuilder orderStr = new StringBuilder();
                orderStr.Append("订单号为" + OrderID + "\n");
                foreach (OrderItem item in OrderItems)
                {
                    orderStr.Append("    " + item.ThisItem.Name + " ￥" +
                        item.ThisItem.Price.ToString() + " *" +
                        item.Num + "共计￥" + item.SumOfPrice + "\n");
                }
                orderStr.Append("订单总计花费 ￥" + SumOfCost + "\n\n");
                return orderStr.ToString();
            }
        }

        public override int GetHashCode()
        {
            var hashCode = 166338653;
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + SumOfCost.GetHashCode();
            return hashCode;
        }
    }
}
