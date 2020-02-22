using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1{
    class Caculator{
        static void Main(string[] args) {
            int temp1;
            int temp2;
            string sign;
            try{
                Console.WriteLine("输入第一个操作数字");
                temp1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("输入第二个操作数字");
                temp2 = Int32.Parse(Console.ReadLine());
            }
            catch (OverflowException){
                Console.WriteLine("输入数字溢出");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("输入数字类型非法");
                return;
            }
            Console.WriteLine("输入操作符(+-*/四选一)");
            sign = Console.ReadLine();
            switch (sign){
                case "+":
                    Console.WriteLine($"结果是{temp1 + temp2}");
                    break;
                case "-":
                    Console.WriteLine($"结果是{temp1 - temp2}");
                    break;
                case "*":
                    Console.WriteLine($"结果是{temp1 * temp2}");
                    break;
                case "/":
                    if (temp2 != 0) Console.WriteLine($"结果是{temp1 / temp2}"); 
                    else{
                        Console.WriteLine("被除数为零错误");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("输入操作符非法");
                    break;
            }
        }
    }
}
