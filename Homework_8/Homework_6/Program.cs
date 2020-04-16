using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework_5
{
    class Program
    {      
        static void Main(string[] args)
        {

            Buyer buyer_1 = new Buyer("GZ");
            Buyer buyer_2 = new Buyer("JP");

            Item ns = new Item("switch", 2000);
            Item game = new Item("Animal Crossing", 400);

            OrderItem oi_1 =new OrderItem(ns,1);
            OrderItem oi_2 = new OrderItem(game, 1);
            OrderItem oi_3 = new OrderItem(game, 2);

            Order order_1 = new Order(buyer_1);
            order_1.AddOrderItem(oi_1);
            order_1.AddOrderItem(oi_2);
            bool flag = order_1.AddOrderItem(oi_3);
            Console.Write(order_1.ToString());

            Order order_2 = new Order(buyer_1);
            order_2.AddOrderItem(oi_1);
            Thread.Sleep(1);
            //OrderID与时间有关，预计每一单处理超过一毫秒会得到不同的ID
            

            Order order_3 = new Order(buyer_2);
            order_3.AddOrderItem(oi_2);
            Thread.Sleep(1);

            Order order_4 = new Order(buyer_2);
            order_4.AddOrderItem(oi_1);
            order_4.AddOrderItem(oi_3);

            OrderService orderService = new OrderService();
            orderService.AddOrder(order_1);
            orderService.AddOrder(order_2);
            orderService.AddOrder(order_3);
            orderService.AddOrder(order_4);
            Console.Write(orderService.ToString());
            orderService.Export("XmlOrderList.xml");
            

            List<Order> results = null;
            results = orderService.Import("XmlOrderList.xml");
            ShowResult(results);
            Order result = null;
            orderService.SearchByBuyer("GZ",out results);
            ShowResult(results);
            orderService.SearchByID(order_3.OrderID, out result);
            ShowResult(result);
            orderService.SearchByItem("switch", out results);
            ShowResult(results);

            orderService.OrderBy();
            Console.Write(orderService.ToString());
            orderService.OrderBy((Order o_1, Order o_2) => (int)(o_1.OrderID - o_2.OrderID));
            Console.Write(orderService.ToString());

            orderService.DeleteByID(order_4.OrderID);
            Console.Write(orderService.ToString());

            OrderItem oi_4 = new OrderItem(ns, 2);
            Console.WriteLine(orderService.ModifyOrder(order_1.OrderID, 1, oi_4));
            orderService.ModifyOrder(order_1.OrderID, 0, oi_1);
            Console.Write(order_1.ToString());
            orderService.ModifyOrder(order_1.OrderID, 1, oi_4);
            Console.Write(order_1.ToString());


        }

        public static void ShowResult(List<Order> results)
        {
            StringBuilder str = new StringBuilder();
            str.Append("结果列表：" + "\n\n");
            int count = 0;
            while (count < results.Count)
            {
                Order o = (Order)results[count];
                str.Append(o.ToString());
                count++;
            }
            Console.Write (str.ToString());
        }

        public static void ShowResult(Order result)
        {
            StringBuilder str = new StringBuilder();
            str.Append("结果列表：" + "\n\n");
           
            Order o = (Order)result;
            str.Append(o.ToString());
               
            Console.Write(str.ToString());
        }
    }
}
