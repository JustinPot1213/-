using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class OrderService
    {
        List<Order> OrderList { get; set; } = new List<Order>();
        public OrderService() { }

        public bool AddOrder(Order order)
        {
            foreach (Order o in OrderList)
            {
                if (o == null) break;
                else if (order.Equals(o)) return false;
            }
            OrderList.Add(order);
            return true;
        }

        public bool SearchByID(long orderID, out Order result)
        {
            var selectedOrder = from o in OrderList
                         where o.orderID == orderID
                         select o;
            if (selectedOrder.Count() == 0)
            {
                result = null;
                return false;
            }
            else
            {
                result = selectedOrder.First();
                return true;
            }
        }

        public bool SearchByBuyer(string buyer, out List<Order> results)
        {
            var selectedOrder = from o in OrderList
                                where o.OrderBuyer.Name.Equals(buyer)
                                orderby o.sumOfCost
                                select o;
            if (selectedOrder.Count() == 0)
            {
                results = null;
                return false;
            }
            else
            {
                results = selectedOrder.ToList();
                return false;
            }
        }

        public bool SearchByItem(string item, out List<Order> results)
        {
            var selectedOrder = from o in OrderList
                                where o.OrderItems.Exists(oi => oi.ThisItem.Name == item)
                                orderby o.sumOfCost
                                select o;              
            if (selectedOrder.Count() == 0)
            {
                results = null;
                return false;
            }
            else
            {
                results = selectedOrder.ToList();
                return false;
            }
        }

        public bool DeleteByID(long orderID)
        {
            Order temp;
            bool flag = SearchByID(orderID, out temp);
            if (flag)
            {
                this.OrderList.Remove(temp);
                return true;
            }
            else return false;
        }

        public string ModifyOrder(long orderID,int type,OrderItem oi) 
        //type=0表示删除，type=1表示增加
        {
            Order temp;
            bool flag = SearchByID(orderID, out temp);
            bool flag_2;
            if (flag)
            {
                switch (type)
                {
                    case 0:
                        flag_2 = temp.DeleteOrderItem(oi);
                        break;
                    case 1:
                        flag_2 = temp.AddOrderItem(oi);
                        break;
                    default:
                        return "type参数错误";
                }
                if (flag_2) return "修改成功";
                else return "修改订单与明细不匹配";
            }
            else return "未找到要修改订单";
        }

        public void OrderBy()
        {
            this.OrderList.Sort((o_1, o_2) => (int)(o_1.sumOfCost - o_2.sumOfCost));
        }

        //public delegate int lambda(Order order_1, Order order_2);
        public void OrderBy(Comparison<Order> myLambda)
        {
            this.OrderList.Sort(myLambda);
        }

        public override string ToString()
        {
            StringBuilder str=new StringBuilder();
            str.Append("订单列表："+"\n\n");
            int count = 0;
            while(count<OrderList.Count)
            {
                Order o = OrderList[count];
                str.Append(o.ToString());
                count++;
            }
            return str.ToString();
        }
    }
}
