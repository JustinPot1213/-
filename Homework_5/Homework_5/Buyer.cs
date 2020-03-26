using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Buyer
    {
        public string Name { get; }

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
