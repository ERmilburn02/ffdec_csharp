using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_helpers_csharp
{
    public class Stopwatch
    {
        private DateTime startTime;
        private TimeSpan elapsedTime;

        private bool running;

        public static Stopwatch startNew()
        {
            Stopwatch sw = new Stopwatch();
            sw.start();
            return sw;
        }

        public void start()
        {
            running = true;
            startTime = DateTime.Now;
        }

        public void stop()
        {
            elapsedTime = DateTime.Now - startTime;
            running = false;
        }

        public double getElapsedMiliseconds()
        {
            if (running)
            {
                return (DateTime.Now - startTime).TotalMilliseconds;
            }
            return elapsedTime.TotalMilliseconds;
        }
    }
}
