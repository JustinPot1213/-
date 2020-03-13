using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    public delegate void Tick(object sender, ClockEventArgs args);
    public delegate void Alarm(object sender, ClockEventArgs args);
    public class ClockEventArgs{}

    class Clock
    {

        public event Tick tick;
        public event Alarm alarm;
        private DateTime now;// = DateTime.Now;
        private readonly DateTime alarmTime;

        public Clock(DateTime alarmTime)
        {
            this.alarmTime = alarmTime;
        }

        public void ClockGo()
        {
            now = DateTime.Now;
            while (true)
            {
                ClockEventArgs args = new ClockEventArgs();
                
                if ((DateTime.Now - now).Seconds != 0)
                {
                    now = DateTime.Now;
                    tick(this, args);
                }
                if ((now - alarmTime).Days == 0
                    && (now - alarmTime).Hours == 0
                    && (now - alarmTime).Minutes == 0
                    &&(now - alarmTime).Seconds == 0
                    && (now - alarmTime).Milliseconds > (-500)
                    && (now - alarmTime).Milliseconds < 500) alarm(this, args);
                //刷屏狂响一整秒
            }
        }     
    }

    class ClockConsole
    {
        public Clock clock;
        public ClockConsole(DateTime alarmTime)
        {
            clock= new Clock(alarmTime);
            clock.tick += ShowTick;
            clock.alarm += ShowAlarm;
        }

        void ShowTick(object sender, ClockEventArgs args)
        {
            Console.WriteLine("TickTack");

        }

        void ShowAlarm(object sender, ClockEventArgs args)
        {
            Console.Write("DingDingDing   ");
        }

    }
}
