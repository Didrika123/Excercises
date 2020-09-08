using System;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while(keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (-1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExcerciseOne();
                            break;
                        case 2:
                            RunExcerciseTwo();
                            break;
                        case 3:
                            RunExcerciseThree();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number.");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExcerciseOne()
        {
            Console.WriteLine("You successfully ran excercise one!\n");
            Console.ResetColor();
            string firstName = "<firstname>", lastName = "<lastname>";
            Console.WriteLine($"Hello {firstName} {lastName}! I'm glad to inform you that you are the test subject of my very first assignment!\n");
        }
        private static void RunExcerciseTwo()
        {
            Console.WriteLine("You successfully ran excercise two!\n");
            Console.ResetColor();
            DateTime dateOfToday = DateTime.Now, 
                     dateOfYesterday = dateOfToday.AddDays(-1), 
                     dateOfTomorrow = dateOfToday.AddDays(1);
            Console.WriteLine($"Todays date is {dateOfToday.ToShortDateString()}\n");
            Console.WriteLine($"Tomorrow's date is {dateOfTomorrow.ToShortDateString()}\n");
            Console.WriteLine($"Yesterday's date is {dateOfYesterday.ToShortDateString()}\n");
            // subtracting two dates, you get back a TimeSpan-object with interval data
        }
        private static void RunExcerciseThree()
        {
            Console.WriteLine("You successfully ran excercise three!");
        }
    }
}
