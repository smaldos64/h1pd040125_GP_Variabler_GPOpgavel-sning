using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GPOpgaveløsning
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Opgaver.ValidatePassword("Pè7$areLove"));
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        private static void TimerTest()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            timer.AutoReset = true;

            // Start the timer
            timer.Enabled = true;

            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine(Opgaver.ValidatePassword("Pè7$areLove"));
            timer.Stop();
            timer.Elapsed += OnTimedEvent;
        }
    }
}
 