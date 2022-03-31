using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Write number for: ");
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stop");
                Console.WriteLine("3. Duration");
                Console.WriteLine("4. Exit");
                Console.WriteLine("");

                var validateInput = int.TryParse(Console.ReadLine(), out var input);


                if (!validateInput)
                {
                    Console.Clear();
                    Console.WriteLine("An invalid command was given");

                }
                else
                {
                    var exit = false;

                    switch (input)
                    {

                        case 1:
                            Console.Clear();
                            newStopwatch.Start();
                            break;
                        case 2:
                            Console.Clear();
                            newStopwatch.Stop();
                            break;
                        case 3:
                            Console.Clear();
                            newStopwatch.DisplayDuration();
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("An invalid command was given. Please try again");
                            break;
                            
                    }

                    if (exit == true)
                        break;
                }
            }
        }
    }
}
