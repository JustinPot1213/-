using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Homework_5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService;

        static OrderItem oi_1;
        static OrderItem oi_2;
        static OrderItem oi_3;
        static OrderItem oi_4;
        static Order order_1;
        static Order order_2;
        static Order order_3;
        static Order order_4;

        [ClassInitialize]
        public static void MyClassInitialize(TestContext arg)
        {

            Buyer buyer_1 = new Buyer("GZ");
            Buyer buyer_2 = new Buyer("JP");

            Item ns = new Item("switch", 2000);
            Item game = new Item("Animal Crossing", 400);

            oi_1 = new OrderItem(ns, 1);
            oi_2 = new OrderItem(game, 1);
            oi_3 = new OrderItem(game, 2);
            oi_4 = new OrderItem(ns, 2);

            order_1 = new Order(buyer_1);
            order_1.AddOrderItem(oi_1);
            order_1.AddOrderItem(oi_2);
            bool flag = order_1.AddOrderItem(oi_3);

            order_2 = new Order(buyer_1);
            order_2.AddOrderItem(oi_1);
            Thread.Sleep(1);
            //OrderID与时间有关，预计每一单处理超过一毫秒会得到不同的ID

            order_3 = new Order(buyer_2);
            order_3.AddOrderItem(oi_2);
            Thread.Sleep(1);

            order_4 = new Order(buyer_2);
            order_4.AddOrderItem(oi_1);
            order_4.AddOrderItem(oi_3);

        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            orderService = new OrderService();
        }



        [TestMethod()]
        public void AddOrderTest()
        {
            bool flag = false;
            flag = orderService.AddOrder(order_1);
            Assert.IsTrue(flag);
            orderService.AddOrder(order_2);
            orderService.AddOrder(order_3);
            orderService.AddOrder(order_4);
        }

        [TestMethod()]
        public void AddOrderTest1()
        {
            bool flag = false;
            AddOrderTest();
            flag = this.orderService.AddOrder(order_1);
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void AddOrderTest2()
        {
            orderService.AddOrder(null);
        }

        [TestMethod()]
        public void SearchByIDTest()
        {
            AddOrderTest();
            Order result = null;
            bool flag = orderService.SearchByID(order_3.OrderID, out result);
            Assert.IsTrue(flag);
            Assert.AreEqual(result, order_3);
        }

        [TestMethod()]
        public void SearchByIDTest1()
        {
            //AddOrderTest();
            Order result = null;
            bool flag = orderService.SearchByID(order_3.OrderID, out result);
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void SearchByBuyerTest()
        {
            AddOrderTest();
            List<Order> results = null;
            bool flag = false;
            flag = orderService.SearchByBuyer("GZ", out results);
            Assert.IsTrue(flag);
            CollectionAssert.Contains(results, order_1);
            CollectionAssert.Contains(results, order_2);
            CollectionAssert.DoesNotContain(results, order_3);
            CollectionAssert.DoesNotContain(results, order_4);
        }

        [TestMethod()]
        public void SearchByBuyerTest1()
        {
            //AddOrderTest();
            List<Order> results = null;
            bool flag = false;
            flag = orderService.SearchByBuyer("GZ", out results);
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void SearchByItemTest()
        {
            AddOrderTest();
            List<Order> results = null;
            bool flag = false;
            flag = orderService.SearchByItem("switch", out results);
            Assert.IsTrue(flag);
            CollectionAssert.Contains(results, order_1);
            CollectionAssert.Contains(results, order_2);
            CollectionAssert.DoesNotContain(results, order_3);
            CollectionAssert.Contains(results, order_4);
        }

        [TestMethod()]
        public void SearchByItemTest1()
        {
            //AddOrderTest();
            List<Order> results = null;
            bool flag = false;
            flag = orderService.SearchByItem("switch", out results);
            Assert.IsFalse(flag);
        }

        [TestMethod()]
        public void DeleteByIDTest()
        {
            AddOrderTest();
            bool flag = orderService.DeleteByID(order_4.OrderID);
            Assert.IsTrue(flag);
            CollectionAssert.Contains(orderService.OrderList, order_1);
            CollectionAssert.Contains(orderService.OrderList, order_2);
            CollectionAssert.Contains(orderService.OrderList, order_3);
            CollectionAssert.DoesNotContain(orderService.OrderList, order_4);
        }

        [TestMethod()]
        public void DeleteByIDTest1()
        {
            AddOrderTest();
            bool flag = orderService.DeleteByID(order_4.OrderID);
            flag = orderService.DeleteByID(order_4.OrderID);
            Assert.IsFalse(flag);
            CollectionAssert.Contains(orderService.OrderList, order_1);
            CollectionAssert.Contains(orderService.OrderList, order_2);
            CollectionAssert.Contains(orderService.OrderList, order_3);
            CollectionAssert.DoesNotContain(orderService.OrderList, order_4);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            string temp = null;
            AddOrderTest();
            temp = orderService.ModifyOrder(order_1.OrderID, 1, oi_4);
            Assert.AreEqual(temp, "修改订单与明细不匹配");
        }

        [TestMethod()]
        public void ModifyOrderTest1()
        {
            ModifyOrderTest();
            string temp = orderService.ModifyOrder(order_1.OrderID, 0, oi_1);
            Assert.AreEqual(temp, "修改成功");
            CollectionAssert.DoesNotContain(order_1.OrderItems, oi_1);
            orderService.ModifyOrder(order_1.OrderID, 1, oi_1);
        }

        [TestMethod()]
        public void ModifyOrderTest2()
        {
            AddOrderTest();
            orderService.ModifyOrder(order_1.OrderID, 0, oi_1);
            string temp = orderService.ModifyOrder(order_1.OrderID, 1, oi_4);
            Assert.AreEqual(temp, "修改成功");
            CollectionAssert.Contains(order_1.OrderItems, oi_4);

            orderService.ModifyOrder(order_1.OrderID, 0, oi_4);
            orderService.ModifyOrder(order_1.OrderID, 1, oi_1);
            //复原修改
        }

        [TestMethod()]
        public void ModifyOrderTest3()
        {
            string temp = null;
            AddOrderTest();
            temp = orderService.ModifyOrder(order_1.OrderID, 2, oi_4);
            Assert.AreEqual(temp, "type参数错误");
        }

        [TestMethod()]
        public void ModifyOrderTest4()
        {
            string temp = null;
            //AddOrderTest();
            temp = orderService.ModifyOrder(order_1.OrderID, 1, oi_4);
            Assert.AreEqual(temp, "未找到要修改订单");
        }

        [TestMethod()]
        public void OrderByTest()
        {
            AddOrderTest();
            orderService.OrderBy();
            List<Order> answer_1 = new List<Order>();
            answer_1.Add(order_3);
            answer_1.Add(order_2);
            answer_1.Add(order_1);
            answer_1.Add(order_4);
            CollectionAssert.AreEqual(answer_1, orderService.OrderList);
        }

        [TestMethod()]
        public void OrderByLambdaTest()
        {
            AddOrderTest();
            orderService.OrderBy();
            orderService.OrderBy((Order o_1, Order o_2) => (int)(o_1.OrderID - o_2.OrderID));
            List<Order> answer_2 = new List<Order>();
            answer_2.Add(order_1);
            answer_2.Add(order_2);
            answer_2.Add(order_3);
            answer_2.Add(order_4);
            CollectionAssert.AreEqual(answer_2, orderService.OrderList);
        }

        [TestMethod()]
        public void ExportTest()
        {
            AddOrderTest();
            orderService.Export("XmlOrderList.xml");
            FileInfo fileInfo = new FileInfo("XmlOrderList.xml");
            Assert.IsTrue(fileInfo.Exists);
            File.Delete("XmlOrderList.xml");
        }

        [TestMethod()]
        public void ImportTest()
        {
            AddOrderTest();
            orderService.Export("XmlOrderList.xml");
            List<Order> results = null;
            results = orderService.Import("XmlOrderList.xml");
            List<Order> answer = new List<Order>();
            answer.Add(order_1);
            answer.Add(order_2);
            answer.Add(order_3);
            answer.Add(order_4);
            CollectionAssert.AreEqual(answer, results);
        }
    }
}