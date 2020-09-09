using System;

namespace Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
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
                        case 10:
                            RunExcerciseTen();
                            break;
                        case 11:
                            RunExcerciseEleven();
                            break;
                        case 12:
                            RunExcerciseTwelve();
                            break;
                        case 13:
                            RunExcerciseThirteen();
                            break;
                        case 14:
                            RunExcerciseFourteen();
                            break;
                        case 15:
                            RunExcerciseFifteen();
                            break;
                        case 16:
                            RunExcerciseSixteen();
                            break;
                        case 17:
                            RunExcerciseSeventeen();
                            break;
                        case 18:
                            RunExcerciseEighteen();
                            break;
                        case 19:
                            RunExcerciseNineteen();
                            break;
                        case 20:
                            RunExcerciseTwenty();
                            break;
                        case 21:
                            RunExcerciseTwentyOne();
                            break;
                        case 22:
                            RunExcerciseTwentyTwo();
                            break;
                        case 23:
                            RunExcerciseTwentyThree();
                            break;
                        case 24:
                            RunExcerciseTwentyFour();
                            break;
                        case 25:
                            RunExcerciseTwentyFive();
                            break;
                        case 26:
                            RunExcerciseTwentySix();
                            break;
                        case 27:
                            RunExcerciseTwentySeven();
                            break;
                        case 28:
                            RunExcerciseTwentyEight();
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

            Console.WriteLine($"Biggest:   \t{(numA < numB ? numB : numA)}");
            Console.WriteLine($"Smallest:  \t{(numA < numB ? numA : numB)}");
            Console.WriteLine($"Difference:\t{numA - numB}");
            Console.WriteLine($"Sum:       \t{numA + numB}");
            Console.WriteLine($"Product:   \t{numA * numB}");
            Console.WriteLine($"Ratio:     \t{Math.Round((double)numA / numB, 2)}");
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
            Console.WriteLine($"n^10:   \t{Math.Pow(num, 10)}");
        }
        private static bool AskYesNoQuestion(string yesnoquestion)
        {
            bool confirm;
            string response = "";
            while (response != "yes" && response != "no")
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

            if (age >= 18)
            {
                if (AskYesNoQuestion("Want a beer? "))
                {
                    Console.WriteLine("A beer, you shall have my dude!");
                }
                else
                {
                    if (AskYesNoQuestion("Want coke? "))
                    {
                        Console.WriteLine("Coke!!!, you shall have my dude!");
                    }
                    else Console.WriteLine("You're too picky. Go home!");
                }
            }
            else
            {
                if (AskYesNoQuestion("Want coke? "))
                {
                    Console.WriteLine("Coke!!!, you shall have my dude!");
                }
                else Console.WriteLine("You're too picky. Go home!");
            }

        }
        private static void RunExcerciseTen()
        {
            int choice = 0, numA, numB;
            while (choice != -1)
            {
                Console.Write("Choice (-1, 1, 2 or 3): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Number A: ");
                        numA = int.Parse(Console.ReadLine());
                        Console.Write("Number B: ");
                        numB = int.Parse(Console.ReadLine());
                        if (numB == 0)
                            Console.WriteLine("Error: Division by Zero.");
                        else
                            Console.WriteLine("A/B equals " + numA / numB);
                        break;
                    case 2:
                        RunExcerciseFour();
                        break;
                    case 3:
                        Console.ForegroundColor = Console.ForegroundColor == ConsoleColor.Blue ? ConsoleColor.Red : ConsoleColor.Blue;
                        break;
                }
            }
        }
        private static void RunExcerciseEleven()
        {
            int num;
            Console.Write("Number: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 0; i < num + 1; i++)
                {
                    if (i % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
                Console.WriteLine("-----------------------------------");
                for (int i = num; i >= 0; i--)
                {
                    if (i % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("ERROR: 0 iS NOT OK");
            }
        }
        private static void RunExcerciseTwelve()
        {
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    Console.Write($"\t{y * x,3}");
                }
                Console.Write("\n");
            }
        }
        private static void RunExcerciseThirteen()
        {
            int numGuesses = 0, guess = -1, randomNumber = new Random().Next(1, 500);

            while (guess != randomNumber)
            {
                Console.Write("Guess the number between 1 and 500: ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;
                if (guess < randomNumber)
                {
                    Console.WriteLine("Too small!");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too big!");
                }
                else
                {
                    Console.WriteLine($"\nHEUREKA, {randomNumber} IS CORRECT! (in {numGuesses} attempts)\n");
                }
            }
        }
        private static void RunExcerciseFourteen()
        {
            int sum = 0, count = 0;
            bool keepCounting = true;

            while (keepCounting)
            {
                Console.Write("Number (-1 to exit): ");
                int input = int.Parse(Console.ReadLine());
                if (input != -1)
                {
                    count++;
                    sum += input;
                }
                else keepCounting = false;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (double) sum / count);
        }
        private static void RunExcerciseFifteen()
        {
            int num;
            Console.Write("\nNumber: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Evenly divisible by: 1");
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                    Console.Write("," + i);
            }
            Console.WriteLine("\n");


            //then do 15B: Write first perfect numbers.
            int x = 4, count = 4; // Perfect number 5 is to inefficient to calculate
            Console.Write($"\nThe first {count} perfect numbers:");
            while (count > 0)
            {
                int sumDivisors = 0;
                for(int y = 1; y < x / 2 + 1; y++)
                {
                    if (x % y == 0)
                        sumDivisors += y;
                }
                if(sumDivisors == x)
                {
                    Console.Write(" " + x);
                    count--;
                }
                x++;
            }
            Console.WriteLine("\n");
        }
        private static void RunExcerciseSixteen()
        {
            int num;
            Console.Write("\nNumber: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Fibonacci numbers:");
            int prevprev = 0, prev = 1, sum;
            for(int i = 0; i < num; i++)
            { 
                Console.Write(" " + prevprev);
                sum = prevprev + prev;
                prevprev = prev;
                prev = sum;
            }
            Console.WriteLine("\n");
        }
        private static void RunExcerciseSeventeen()
        {
            string input;
            Console.Write("\nWord: ");
            input = Console.ReadLine().ToLower().Replace(" ", "");
            bool palindrome = true;
            int len = input.Length;
            //if its odd length string just ignore center char (since it will always palindromize)
            for (int i = 0; i < len / 2 && palindrome; i++)
            {
                if (input[i] != input[len - i - 1])
                    palindrome = false;
            }
            Console.WriteLine("A palindrome? " + palindrome + "\n");
        }
        private static void RunExcerciseEighteen()
        {
            Console.WriteLine();
            var numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = new Random().Next(1, 100);
            var doubles = new double[10];
            for (int i = 0; i < numbers.Length; i++)
                doubles[i] = 1.0 / numbers[i];
            foreach (var num in numbers)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();
            foreach (var num in doubles)
            {
                Console.Write(Math.Round(num, 3) + "\t");
            }
            Console.WriteLine("\n");

        }
        private static void RunExcerciseNineteen()
        {
            var cashUnits = new int[] { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            var cashUnitsStr = new string[] { "Enkronor", "Tvakronor", "Femmor", "Tior", "Tjugolappar", "Femtilappar", "Hundralappar", "Tvahundralappar", "Femhundralappar" } ;
            int price = new Random().Next(1, 1000), cashGiven;
            Console.Write($"\nThe total price amounts to {price} kr.\nYou give me cash: ");
            cashGiven = int.Parse(Console.ReadLine());

            int change = cashGiven - price;
            int numCashUnits = cashUnits.Length;
            var changeInUnits = new int[numCashUnits];
            Console.WriteLine($"\nYou're change is {change} kr, given to you in the following units:\n");
            while (change > 0)
            {
                for(int i = numCashUnits - 1; i >= 0 ; i--)
                {
                    int cashUnit = cashUnits[i];
                    changeInUnits[i] = change / cashUnit;
                    change = change % cashUnit;
                }
            }
            for (int i = numCashUnits - 1; i >= 0; i--)
            {
                int numOfUnit = changeInUnits[i];
                if (numOfUnit > 0)
                {
                    Console.WriteLine($"{cashUnitsStr[i]+ ":", -20} {numOfUnit} st");
                }
            }
            Console.WriteLine("\nTHANK YOU COME AGAIN!\n");
        }
        private static void RunExcerciseTwenty()
        {
            int size = 10, numEven = 0, numOdd = 0;
            var numbers = new int[size];
            var numbersSortedIsh = new int[size];
            for (int i = 0; i < size; i++)
                numbers[i] = new Random().Next(1, 100);
            Array.Sort(numbers);
            foreach (var num in numbers)
            {
                Console.Write(num + "\t");
                if (num % 2 == 0)
                    numbersSortedIsh[numEven++] = num;
                else
                    numbersSortedIsh[size - 1 - numOdd++] = num;
            }
            Console.WriteLine();
            foreach (var num in numbersSortedIsh)
            {
                Console.Write(num + "\t");
            }
            Console.WriteLine();
        }
        private static void RunExcerciseTwentyOne()
        {
            string input;
            Console.Write("\nNumbers separated by comma (,): ");
            input = Console.ReadLine().Replace(" ", "");
            var numberStrings = input.Split(',');
            int len = numberStrings.Length;
            int sum = 0, min = int.MaxValue, max = int.MinValue;
            foreach(var numStr in numberStrings)
            {
                int num = int.Parse(numStr);
                sum += num;
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }
            double average = Math.Round((double)sum / len, 2);
            Console.WriteLine($"Max: {max}\t Min: {min}\t Average: {average}");
        }
        private static void RunExcerciseTwentyTwo()
        {
            var swears = new string[] { "bollocks", "hell", "god" }; //Do not invoke God in vain
            Console.Write("\nProfanity filter: ");
            string input = Console.ReadLine();
            StringComparison strcomp = StringComparison.OrdinalIgnoreCase;
            foreach(var swear in swears)
            {
                input = input.Replace(swear, "*****", strcomp);
            }
            Console.WriteLine("Filtered output: " + input);
        }
        private static void RunExcerciseTwentyThree()
        {
            int len = 7, min = 1, max = 27;
            var uniqueNumbers = new int[len];
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                bool unique = false;
                int newNumber = -1;
                while (!unique)
                {
                    unique = true;
                    newNumber = random.Next(min, max + 1);
                    for (int j = 0; j < i && unique; j++)
                    {
                        if (uniqueNumbers[j] == newNumber)
                            unique = false;
                    }
                }
                uniqueNumbers[i] = newNumber;
            }
            //Array.Sort(uniqueNumbers);
            Console.WriteLine($"{len} Unique & Random numbers between {min} and {max+1}:");
            foreach (var num in uniqueNumbers)
            {
                Console.Write($"{num + "\t", 0}");
            }
            Console.WriteLine();
        }
        static int DrawCard(ref int[] deck)
        {
            int drawnCard = 0;
            return drawnCard;
        }
        static void ShuffleCards(ref int[] deck)
        {

        }
        private static void RunExcerciseTwentyFour()
        {
        }
        private static void RunExcerciseTwentyFive()
        {
        }
        private static void RunExcerciseTwentySix()
        {
        }
        private static void RunExcerciseTwentySeven()
        {
        }
        private static void RunExcerciseTwentyEight()
        {
        }
    }
}
