using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework_5;
using System.Threading;

namespace Homework_8
{
    public partial class OrderServiceForm : Form
    {
        OrderService orderService = new OrderService();
        public List<Buyer> Buyers { get; set; } = new List<Buyer>();
        public List<Item> Items { get; set; } = new List<Item>();

        public OrderServiceForm()
        {
            InitializeComponent();

            Buyer buyer_1 = new Buyer("GZ");
            Buyer buyer_2 = new Buyer("JP");
            Buyers.Add(buyer_1);
            Buyers.Add(buyer_2);

            Item ns = new Item("switch", 2000);
            Item game = new Item("Animal Crossing", 400);
            Items.Add(ns);
            Items.Add(game);

            OrderItem oi_1 = new OrderItem(ns, 1);
            OrderItem oi_2 = new OrderItem(game, 1);
            OrderItem oi_3 = new OrderItem(game, 2);

            Order order_1 = new Order(buyer_1);
            order_1.AddOrderItem(oi_1);
            order_1.AddOrderItem(oi_2);

            Order order_2 = new Order(buyer_2);
            order_2.AddOrderItem(oi_3);
            Thread.Sleep(1);
            //OrderID与时间有关，预计每一单处理超过一毫秒会得到不同的ID

            orderService.AddOrder(order_1);
            orderService.AddOrder(order_2);

            using (var db = new OrderContext())
            {
                var allOrders = db.Orders.OrderBy(order=>order.OrderID);
                
                orderBindingSource.DataSource = allOrders.ToList<Order>();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Order current = (Order)orderBindingSource.Current;
                orderService.DeleteByID(current.OrderID);
                orderBindingSource.ResetBindings(false);
            }
            catch { }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            long ID;
            string itemOrBuyer;
            Order result=null;
            List<Order> results=null;
            OrderService os = new OrderService();
            switch (searchComboBox.SelectedIndex)
            {
                
                case (0):
                    try
                    {
                        ID = long.Parse(searchTextBox.Text);
                        orderService.SearchByID(ID, out result);
                        os.AddOrder(result);
                        orderBindingSource.DataSource = os.OrderList;
                    }
                    catch (OverflowException)
                    {
                        warningLabel.Text += "\n查询输入数字溢出";
                    }
                    catch (FormatException)
                    {
                        warningLabel.Text += "\n查询输入数字类型非法";
                    }
                    catch (ArgumentException)
                    {
                        orderBindingSource.DataSource = os.OrderList;
                    }
                    break;
                case (1):
                    itemOrBuyer = searchTextBox.Text;
                    orderService.SearchByItem(itemOrBuyer, out results);
                    if (results != null)
                    {
                        foreach (Order o in results)
                        {
                            os.AddOrder(o);
                        }
                    }
                    orderBindingSource.DataSource = os.OrderList;
                    break;
                case (2):
                    itemOrBuyer = searchTextBox.Text;
                    orderService.SearchByBuyer(itemOrBuyer, out results);
                    if (results != null)
                    {
                        foreach (Order o in results)
                        {
                            os.AddOrder(o);
                        }
                    }
                    orderBindingSource.DataSource = os.OrderList;
                    break;
                case (3):
                    orderBindingSource.DataSource = orderService.OrderList;
                    break;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            //orderService.Export(fileTextBox.Text);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            /*
            List<Order> results;
            OrderService os = new OrderService();
            results=orderService.Import(fileTextBox.Text);
            foreach (Order o in results)
            {
                os.AddOrder(o);
            }
            orderService = os;
            orderBindingSource.DataSource = os.OrderList;
            */
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm(Buyers,Items);
            sub.ShowDialog();
            if (sub.DialogResult == DialogResult.OK)
            {
                foreach (Order o in sub.results)
                {
                    orderService.AddOrder(o);
                }
                orderService.OrderBy();
                orderBindingSource.ResetBindings(false);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Order current = new Order();
            current = (Order)orderBindingSource.Current;
            SubForm sub = new SubForm(Buyers,Items,current)
            {
                Buyers = Buyers,
                Items = Items
            };
            sub.ShowDialog();
            if (sub.DialogResult == DialogResult.OK)
            {
                orderBindingSource.Remove(orderBindingSource.Current);
                foreach (Order o in sub.results)
                {
                    orderService.AddOrder(o);
                }
                orderService.OrderBy();
                orderBindingSource.ResetBindings(false);
            }
        }

        private void OrderServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“orderdbDataSet.orders”中。您可以根据需要移动或删除它。

        }

    }
}
