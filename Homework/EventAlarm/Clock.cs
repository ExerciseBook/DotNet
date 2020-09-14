using System.Threading;

namespace EventAlarm
{
    public class Clock
    {

        public delegate void Tick(long time);

        public event Tick TickList;

        public delegate void Alarm(long time);

        public event Alarm ALarmList;

        public void Worker()
        {
            long t = 0;
            while (true)
            {
                t++;

                if (t % 1 == 0)
                {
                    TickList?.Invoke(t);
                }

                if (t % 10 == 0)
                {
                    ALarmList?.Invoke(t);
                }


                Thread.Sleep(1000);
            }

        }
    }
}