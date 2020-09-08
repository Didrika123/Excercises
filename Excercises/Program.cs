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
                        case 4:
                            RunExcerciseFour();
                            break;
                        case 5:
                            RunExcerciseFive();
                            break;
                        case 6:
                            RunExcerciseSix();
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
            Console.WriteLine($"Today's date is {dateOfToday.ToShortDateString()}\n");
            Console.WriteLine($"Tomorrow's date is {dateOfTomorrow.ToShortDateString()}\n");
            Console.WriteLine($"Yesterday's date is {dateOfYesterday.ToShortDateString()}\n");
            // subtracting two dates, you get back a TimeSpan-object with interval data
        }
        private static void RunExcerciseThree()
        {
            Console.WriteLine("You successfully ran excercise three!\n");
            Console.ResetColor();

            string firstName = "<firstname>", lastName = "<lastname>";
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"\nHello {firstName} {lastName}!\n");
        }
        private static void RunExcerciseFour()
        {
            Console.WriteLine("You successfully ran excercise four!\n");
            Console.ResetColor();

            string str = "The quick fox Jumped Over the DOG";
            //Transform into “The brown fox jumped over the lazy dog”
            string newStr = "T" + str.Substring(1).ToLower().Replace("quick", "brown").Replace("dog", "lazy dog");
            Console.WriteLine(newStr + "\n");
        }
        private static void RunExcerciseFive()
        {
            Console.WriteLine("You successfully ran excercise five!\n");
            Console.ResetColor();

        }
        private static void RunExcerciseSix()
        {
            Console.WriteLine("You successfully ran excercise six!\n");
            Console.ResetColor();

        }
    }
}
