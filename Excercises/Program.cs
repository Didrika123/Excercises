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
                        case 7:
                            RunExcerciseSeven();
                            break;
                        case 8:
                            RunExcerciseEight();
                            break;
                        case 9:
                            RunExcerciseNine();
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

            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            string newStr = str.Substring(str.IndexOf('[')).Replace("2,3,", "");
            newStr = newStr.Insert(newStr.IndexOf(']'), ",6,7,8,9,10");
            Console.WriteLine(newStr + "\n");
        }
        private static void RunExcerciseSix()
        {
            int numA, numB;
            Console.Write("Number A: ");
            numA = int.Parse(Console.ReadLine());
            Console.Write("Number B: ");
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Biggest:   \t{(numA < numB? numB : numA)}");
            Console.WriteLine($"Smallest:  \t{(numA < numB ? numA : numB)}");
            Console.WriteLine($"Difference:\t{numA - numB}");
            Console.WriteLine($"Sum:       \t{numA + numB}");
            Console.WriteLine($"Product:   \t{numA * numB}");
            Console.WriteLine($"Ratio:     \t{Math.Round((double) numA / numB, 2)}");
        }
        private static void RunExcerciseSeven()
        {
            double num;
            Console.Write("Radius: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("Area:   " + Math.Round(num * num * Math.PI, 2) + " au");
            Console.WriteLine("Volume: " + 4 * Math.Round(Math.Pow(num, 3) * Math.PI / 3, 2) + " vu");
        }
        private static void RunExcerciseEight()
        {
            double num;
            Console.Write("Number: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine($"√n:     \t{Math.Round(Math.Sqrt(num), 2)}");
            Console.WriteLine($"n^2:    \t{num * num}");
            Console.WriteLine($"n^10:   \t{Math.Pow(num,10)}");
        }
        private static bool IsUserWilling(string yesnoquestion)
        {
            bool confirm;
            string response = "";
            while(response != "yes" && response != "no")
            {
                Console.Write(yesnoquestion);
                response = Console.ReadLine().ToLower();
            }
            if (response == "yes")
                confirm = true;
            else 
                confirm = false;
            return confirm;
        }
        private static void RunExcerciseNine()
        {
            string name = "<name>";
            int birthyear, age;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write($"Greetings {name}!\nWhat is your birth year?");
            birthyear = int.Parse(Console.ReadLine());
            age = DateTime.Now.Year - birthyear;

            if(age >= 18)
            {
                if(IsUserWilling("Want a beer? "))
                {
                    Console.WriteLine("A beer, you shall have my dude!");
                }
                else
                {
                    if (IsUserWilling("Want coke? "))
                    {
                        Console.WriteLine("Coke!!!, you shall have my dude!");
                    }
                    else Console.WriteLine("You're too picky. Go home!");
                }
            }
            else
            {
                if (IsUserWilling("Want coke? "))
                {
                    Console.WriteLine("Coke!!!, you shall have my dude!");
                }
                else Console.WriteLine("You're too picky. Go home!");
            }

        }
    }
}
