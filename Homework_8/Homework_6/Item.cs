using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Homework_5
{
    [Serializable]
    public class Item
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public double Price { get; set; }

        public Item() { }

        public Item(string itemName,double price)
        {
            this.Name = itemName;
            this.Price = price;
        }

        public override string ToString()
        {
            return this.Name + " ￥" + Price.ToString();
        }
    }
}
