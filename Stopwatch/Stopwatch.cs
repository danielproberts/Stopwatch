using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    class Stopwatch
    {
        public bool isRunning { get; set; }
        public DateTime startTime { get; set; }
        public DateTime stopTime { get; set; }
        public TimeSpan duration { get; set; }

        public void Start()
        {
            if (isRunning == true)
            {
                throw new Exception("Cannot start stopwatch. Already Running");
            }
            startTime = DateTime.Now;
            isRunning = true;

        }

        public void Stop()
        {
            if(isRunning ==false)
            {
                throw new Exception("Stopwatch is not running.");
            }

            stopTime = DateTime.Now;
            isRunning = false;

            duration = stopTime - startTime;

        }
    }
}
