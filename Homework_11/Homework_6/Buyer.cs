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
    public class Buyer
    {
        [XmlAttribute]
        //public int BuyerID { get; set; }
        public int BuyerID { get; set; }
        public string BuyerName { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Buyer() { }

        public Buyer(string name)
        {
            this.BuyerName = name;
            //this.BuyerID = GetHashCode();
        }

        public override string ToString()
        {
            return  BuyerName + "\n";
        }
    }
}
