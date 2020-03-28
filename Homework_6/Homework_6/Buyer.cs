using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_5
{
    [Serializable]
    public class Buyer
    {
        [XmlAttribute]
        public string Name { get; set; }

        public Buyer() { }

        public Buyer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "该订单购买人是" + Name + "\n";
        }
    }
}
