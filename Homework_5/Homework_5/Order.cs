using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Order
    {
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();
        public Buyer OrderBuyer { get; }
        public long orderID { get; }
        public double sumOfCost { get; set; }
        Order(Buyer buyer, List<OrderItem> orderItems)
        {
            this.OrderBuyer = buyer;
            foreach (OrderItem item in orderItems){
                this.OrderItems.Add(item);
            }
            DateTime n = DateTime.Now;
            orderID = n.Second+n.Minute*100+n.Hour*100+n.Day*100+n.Month*100;
        }

        public Order(Buyer buyer)
        {
            this.OrderBuyer = buyer;
            DateTime n = DateTime.Now;
            orderID = n.Millisecond*10 +
                      n.Second * 10000 +
                      n.Minute * 1000000 +
                      n.Hour * 100000000;
            this.sumOfCost = 0;
        }

        public bool AddOrderItem(OrderItem oi)
        {

            foreach (OrderItem item in OrderItems)
            {
                if (item == null) break;
                else if (oi.Equals(item)) return false;
            }
            OrderItems.Add(oi);
            sumOfCost += oi.ThisItem.Price * oi.Num;
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
                    sumOfCost -= oi.ThisItem.Price * oi.Num;
                    return true;
                }
            }
            
            return false;
        }

        public override bool Equals(object obj)
        {
            Order temp = obj as Order;
            return temp != null && temp.orderID == this.orderID;
        }

        public override string ToString()
        {
            StringBuilder orderStr=new StringBuilder();
            orderStr.Append ("订单号为" + orderID + "\n" + this.OrderBuyer.ToString());
            foreach (OrderItem item in OrderItems)
            {
                orderStr.Append("    "+item.ToString());
            }
            orderStr.Append("订单总计花费 ￥" + sumOfCost+"\n\n");
            return orderStr.ToString();
        }

        public override int GetHashCode()
        {
            var hashCode = 574100415;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + EqualityComparer<Buyer>.Default.GetHashCode(OrderBuyer);
            hashCode = hashCode * -1521134295 + orderID.GetHashCode();
            hashCode = hashCode * -1521134295 + sumOfCost.GetHashCode();
            return hashCode;
        }
    }
}
