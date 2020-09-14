using System;

namespace EventAlarm
{
    class Program
    {


        static void Main(string[] args)
        {
            Clock clock = new Clock();

            clock.TickList += (s) => Console.WriteLine("T " + s);
            clock.ALarmList += (s) => Console.WriteLine("A " + s);

            clock.Worker();
        }
    }
}
