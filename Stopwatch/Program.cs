using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var watch = new Stopwatch();
            Console.WriteLine("Press Return to start Stopwatch");
            Console.ReadKey();
            watch.Start();
            Console.WriteLine("Stopwatch is Running...");
            Console.WriteLine("Press Return to stop Stopwatch");
            Console.ReadKey();
            watch.Stop();
            Console.WriteLine();
            Console.WriteLine("Start Time: " + watch.startTime);
            Console.WriteLine("Stop Time: " + watch.stopTime);
            Console.WriteLine("Duration: " + watch.duration + " seconds");
            Console.ReadKey();
        }
    }
}
