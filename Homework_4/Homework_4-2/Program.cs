using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime alarmTime = DateTime.Now.Add(TimeSpan.FromSeconds(5));
            //为了测试方便闹钟时间设置为开始走针后5s
            ClockConsole clockConsole = new ClockConsole(alarmTime);
            clockConsole.clock.ClockGo();
        }
    }
}
