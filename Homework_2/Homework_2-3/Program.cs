using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_3
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2~100中的质数有：");
            int[] ini = InitializeArray(99);
            int[] result = FindPrimeNum(ini);
            int count = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != 0)
                {
                    Console.Write($"{result[i]} ");
                    count++;
                }
                if (count == 10)
                {
                    Console.Write("\n");
                    count = 0;
                }
            }

        }

        static int[] InitializeArray(int size) //生成整数数组从2开始
        {
            int[] ini=new int[size];
            for (int i = 0; i < size; i++)
            {
                ini[i] = i + 2;
            }
            return ini;
        }

        static int[] FindPrimeNum(int[] ini)
        {
            int temp;
            for(int i = 0; i < ini.Length; i++)
            {
                if (ini[i] != 0)
                {
                    temp = ini[i];
                    for (int j = i + temp; j < ini.Length; j += temp) ini[j] = 0;
                }
            }
            return ini;
        }

    }
}
