using System;

namespace EventAlarm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var clock = new Clock();

            clock.TickList += s => Console.WriteLine("T " + s);
            clock.ALarmList += s => Console.WriteLine("A " + s);

            clock.Worker();
        }
    }
}