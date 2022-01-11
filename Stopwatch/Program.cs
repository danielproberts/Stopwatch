using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var watch = new Stopwatch();
            watch.Start();
            Console.ReadKey();
            watch.Stop();
            Console.WriteLine(watch.startTime);
            Console.WriteLine(watch.stopTime);
            Console.WriteLine(watch.duration);
            Console.ReadKey();
        }
    }
}
