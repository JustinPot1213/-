using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace Homework_5
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; } = new List<Order>();
        //public XmlSerializer Xml { get; } = new XmlSerializer(typeof(List<Order>));
        public OrderService() {
            using (var db = new OrderContext())
            {
                foreach(var order in db.Orders)
                {
                    db.Orders.Remove(order);
                }
                db.SaveChanges();
            }
        }

        public bool AddOrder(Order order)
        {
            using (var db=new OrderContext())
            {
                if (order == null) throw new ArgumentException();
                foreach (var o in db.Orders)
                {
                    if (o == null) break;
                    else if (order.OrderID==o.OrderID) return false;
                }
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
            
        }

        public bool SearchByID(long orderID, out Order result)
        {
            using (var db = new OrderContext())
            {
                var selectedOrder = from o in db.Orders
                                    where o.OrderID == orderID
                                    select o;
                if (selectedOrder.Count() == 0)
                {
                    result = null;
                    return false;
                }
                else
                {
                    result = selectedOrder.First<Order>();
                    return true;
                }
            }
           
        }

        public bool SearchByBuyer(string buyer, out List<Order> results)
        {
            using (var db = new OrderContext())
            {
                var selectedOrder = from o in db.Orders
                                    where o.Buyer.BuyerName == buyer
                                    orderby o.SumOfCost
                                    select o;
                if (selectedOrder.Count() == 0)
                {
                    results = null;
                    return false;
                }
                else
                {
                    results = selectedOrder.ToList();
                    return true;
                }
            }
            
        }

        public bool SearchByItem(string item, out List<Order> results)
        {
            List<Order> selectedOrder=new List<Order>();
            using (var db = new OrderContext())
            {
                foreach(var o in db.Orders)
                {
                    foreach(var oi in o.OrderItems)
                    {
                        if (oi.ThisItem.Name == item)
                        {
                            selectedOrder.Add(o);
                            break;
                        }
                    }
                }
                if (selectedOrder == null)
                {
                    results = null;
                    return false;
                }
                else
                {
                    results = selectedOrder;
                    return true;
                }
            }
            

        }

        public bool DeleteByID(long orderID)
        {
            using (var db = new OrderContext())
            {
                var selectedOrder = from o in db.Orders
                                    where o.OrderID == orderID
                                    select o;
                if (selectedOrder!=null)
                {
                    db.Orders.Remove(selectedOrder.First());
                    db.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

        public string ModifyOrder(long orderID,int type,OrderItem oi) 
        //type=0表示删除，type=1表示增加
        {
            using (var db = new OrderContext())
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
        }

        public void OrderBy()
        {
            using (var db = new OrderContext())
            {
                var orders = db.Orders.
                    OrderBy(o=>o.SumOfCost);
            }
        }

        /*
        //public delegate int lambda(Order order_1, Order order_2);
        public void OrderBy(Comparison<Order> myLambda)
        {
            //this.OrderList.Sort(myLambda);
        }
        */
        public override string ToString()
        {
            using (var db = new OrderContext())
            {
                StringBuilder str = new StringBuilder();
                str.Append("订单列表：" + "\n\n");
                foreach (var o in AllOrders(db))
                {
                    str.Append(o.ToString());
                }
                return str.ToString();
            }
        }
        /*
        public void Export(string filePath)
        {
            using (FileStream fs=new FileStream(filePath,FileMode.Create))
            {
                using (var db = new OrderContext())
                {
                    //Xml.Serialize(fs, db.Orders);
                }
            }
        }

        public List<Order> Import(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                List<Order> xmlOrderList = (List<Order>)Xml.Deserialize(fs);
                return xmlOrderList;
            }
        }
        */

        public IQueryable<Order> AllOrders(OrderContext db)
        {
            return db.Orders.Include("OrderItems")
                            .Include("Buyer"); 
        }

        public List<Order> GetAllOrders()
        {
            using (var db = new OrderContext())
            {
                return AllOrders(db).ToList();
            }
        }
    }
}
