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

namespace Homework_8
{
    public partial class SubForm : Form
    {

        public List<Buyer> Buyers { get; set; } = new List<Buyer>();
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Order> results { get; set; } = new List<Order>();

        OrderService orderService = new OrderService();

        public SubForm()
        {
            InitializeComponent();
            orderBindingSource.DataSource = orderService.OrderList;
            this.addItemTextBox.Visible = false;
            this.addItemComboBox.Visible = false;

        }

        public SubForm(List<Buyer> Buyers, List<Item> Items):this()
        {
            
            this.Items = Items;
            this.Buyers = Buyers;
            addItemComboBox.DataSource = Items;
            buyersComboBox.DataSource = Buyers;
        }

        public SubForm(List<Buyer> Buyers, List<Item> Items,Order current) : this(Buyers,Items)
        {
            orderService.AddOrder(current);
            orderBindingSource.ResetBindings(false);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

            try
            {
                Order o = (Order)orderBindingSource.Current;
                OrderItem i = (OrderItem)orderItemsBindingSource.Current;
                string s;
                switch (modifyComboBox.SelectedIndex)
                {
                    case (0):
                        s = orderService.ModifyOrder(o.OrderID, 0, i);
                        orderItemsBindingSource.ResetBindings(false);
                        orderBindingSource.ResetBindings(false);
                        warningLabel.Text = "提示：" + s;
                        break;
                    case (1):
                        int num;
                        try
                        {
                            num = Int32.Parse(addItemTextBox.Text);
                            OrderItem oi = new OrderItem(Items.ToArray()[addItemComboBox.SelectedIndex], num);
                            s=orderService.ModifyOrder(o.OrderID, 1, oi);
                            orderItemsBindingSource.ResetBindings(false);
                            orderBindingSource.ResetBindings(false);
                            warningLabel.Text = "提示：" + s;
                        }
                        catch (OverflowException)
                        {
                            warningLabel.Text = "提示：" + "输入数字溢出";
                        }
                        catch (FormatException)
                        {
                            warningLabel.Text = "提示：" + "输入数字类型非法";
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }    
        }

        private void modifyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modifyComboBox.SelectedIndex)
            {
                case (0):
                    this.addItemTextBox.Visible = false;
                    this.addItemComboBox.Visible = false;
                    break;
                case (1):
                    this.addItemComboBox.Visible = true;
                    this.addItemTextBox.Visible = true;
                    break;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(Buyers[buyersComboBox.SelectedIndex]);
            orderService.AddOrder(order);
            orderBindingSource.ResetBindings(false);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            results = orderService.OrderList;
            this.Close();
        }
    }
}
