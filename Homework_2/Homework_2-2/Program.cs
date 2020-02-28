using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    using System;
    using System.Collections;

    class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数数组（一行一个数字，空行表示结束）");
            ArrayList al = new ArrayList();
            string s;
            s = Console.ReadLine();
            int n;
            while (s != "")
            {
                try
                {
                    n = Int32.Parse(s);
                    al.Add(n);
                    s = Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("输入数字溢出");
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入数字类型非法");
                    return;
                }
            }
            int[] a = (int[])al.ToArray(Type.GetType("System.Int32"));
            ResultOfArray(a);
            return;
        }

        static int MaxOfArray(int[] a){
            int max=a[0];
            for(int i = 0; i < a.Length; i++){
                max=a[i]>max? a[i]:max;
            }
            return max;
        }

        static int MinOfArray(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                min = a[i] < min ? a[i] : min;
            }
            return min;
        }

        static int SumOfArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++) sum += a[i];
            return sum;
        }

        static int AverageOfArray(int[] a)
        {
            int average;
            average = SumOfArray(a) / a.Length;
            return average;
        }

        static void ResultOfArray(int[] a)
        {
            Console.WriteLine("数组的最大值是" + MaxOfArray(a));
            Console.WriteLine("数组的最小值是" + MinOfArray(a));
            Console.WriteLine("数组的平均值是" + AverageOfArray(a));
            Console.WriteLine("数组的和是" + SumOfArray(a));
        }
    }
}
