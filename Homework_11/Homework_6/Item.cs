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
    public class Item
    {
        public int ItemID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public double Price { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public Item() { }

        public Item(string itemName,double price)
        {
            this.Name = itemName;
            this.Price = price;
            //ItemID = this.GetHashCode();
        }

        public override string ToString()
        {
            return this.Name + " ￥" + Price.ToString();
        }
    }
}
