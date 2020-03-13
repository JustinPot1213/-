using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }

            int max = Int32.MinValue, min = Int32.MaxValue, sum = 0;
            //Action<int> IntShow = x => Console.WriteLine(x);
            intlist.ForEach(x => Console.WriteLine(x));
            intlist.ForEach(x => max = x > max ? x : max);
            Console.WriteLine($"数组最大值是{max}");
            intlist.ForEach(x => min = x < min ? x : min);
            Console.WriteLine($"数组最小值是{min}");
            intlist.ForEach(x => sum += x);
            Console.WriteLine($"数组总值是{sum}");


            /*
            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }

            Action<string> StringShow = x => Console.WriteLine(x);
            */

        }

    }
}


