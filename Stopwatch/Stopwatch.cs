using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime DateStart { get; set; }

        private DateTime DateStop { get; set; }

        private bool Working { get; set; }


        public Stopwatch()
        {
            Working = false;
        }

    public void Start()
        {
            if (!Working)
            {
                Working = true;
                DateStart = DateTime.Now;
               
            }
            else
            {
                Console.WriteLine("First stop the stopwatch");
            }
        }

        public void Stop()
        {
            if (Working)
            {
                Working = false;
                DateStop = DateTime.Now;
            }
            else
            {
                Console.WriteLine("First start the stopwatch");
            }

        }

        public void DisplayDuration()
        {
            if (Working)
            {
                Console.WriteLine("First stop the stopwatch");
            }
            else if (DateStop == DateStart)
            {
                Console.WriteLine("First start the stopwatch");
            }
            else
            {
                Console.WriteLine("Duration: " + (DateStop - DateStart));
            }
        }

    }
}
