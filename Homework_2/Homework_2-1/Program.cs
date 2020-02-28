using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    using System;

    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("请输入一个要求质数因子的正整数");
            int n;
            try{
                n = Int32.Parse(Console.ReadLine());
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
            Console.WriteLine("素数因子有");
            findPrimeFactor(n);
            return;
        }

        static bool isPrimeNum(int num){
            double middle = Math.Pow(num,0.5);
            if (num == 1) return false;
            else{
                for (int i = 2; i <= middle; i++){
                    int temp = num / i;
                    if (num == temp * i) return false;
                }
                return true;
            }
        }

        static void findPrimeFactor(int n){
            if (n <= 0){
                Console.WriteLine("请输入正数");
                return;
            }
            else{
                for (int i = 1; i <= n; i++){
                    int temp = n / i;
                    if (n == temp * i) {
                        if (isPrimeNum(i)){
                            Console.Write($"{i} ");
                            findPrimeFactor(temp);
                            return;
                        }
                    }
                }
                return;
            }
            
        }
    }
}
