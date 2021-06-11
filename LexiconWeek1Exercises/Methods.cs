using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LexiconWeek1Exercises
{
    public partial class Program
    {
        private static void RunExerciseOne()
        {
            string firstName = "Dennis";
            string lastName = "Olsen";

            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            //Get todays date with DateTime.Now then we remove the time by uisng .date on our variable
            DateTime todaysDate = DateTime.Now;
            //Then we get yesterdays date by using AddDays with an negativ 1 as argument
            //And tomorrows by using a positiv 1 as an argument
            DateTime yesterdaysDate = todaysDate.AddDays(-1);
            DateTime tomorrowsDate = todaysDate.AddDays(1);

            Console.WriteLine($"Todays date is {todaysDate::d}");
            Console.WriteLine($"Tomorrows date is {tomorrowsDate::d}");
            Console.WriteLine($"Yesterdays date was {yesterdaysDate::d}");
        }

        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string usersFirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string usersLasteName = Console.ReadLine();

            Console.WriteLine(usersFirstName + ' ' + usersLasteName);
        }

        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";

            Console.WriteLine("Before: " + str);

            //First we use replace to replace quick, Jumped and Over
            //because the "Replace" function search for word we put as teh first argument
            //and replace it with the second argument, that makes the first part easy
            str = str.Replace("quick", "brown");
            str = str.Replace("Jumped", "jumped");
            str = str.Replace("Over", "over");
            //Second we find the index of the word DOG with indexOf and the word "DOG" as an argument
            int index = str.IndexOf("DOG");
            //Then we remove the index of "DOG"
            str = str.Remove(index);
            //Lastly we just insert "lazy dog" last by using str.length as the first argument
            str = str.Insert(str.Length, "lazy dog");

            Console.WriteLine("After: " + str);
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            //Take a substring from str that starts at [ and ends at the end
            string numbersOnly = str.Substring(str.IndexOf("["));
            //Remove ",2,3" by using indexOf to start at 2 and the second argument is how much should be removed
            //and we already know we need to remove 4 characters
            numbersOnly = numbersOnly.Remove(numbersOnly.IndexOf("2"), 4);
            //Now we only need to insert ,6,7,8,9,10 almost at the end, so we use insert but to specify were
            //we use length-1 otherwise we start after ], then the second argument is just what we want to add
            numbersOnly = numbersOnly.Insert(numbersOnly.Length - 1, ",6,7,8,9,10");

            Console.WriteLine(numbersOnly);
        }

        private static void RunExerciseSix()
        {
            double firstNumber = 0.0, secondNumber = 0.0;
            //If it isn't a number, Parse will use "" which will trigger the catch
            Console.Write("Input a number:");

            if (getADecimalFromUser(ref firstNumber))
            {
                Console.Write("Input another number:");
                if (getADecimalFromUser(ref secondNumber))
                {
                    //We use ?: operator to check which variable is larger and output that one on one line
                    Console.WriteLine(firstNumber > secondNumber ? $"Biggest: {firstNumber}" : $"Biggest: {secondNumber}");
                    //Samething but smallest of them
                    Console.WriteLine(firstNumber < secondNumber ? $"Smallest: {firstNumber}" : $"Smallest: {secondNumber}");
                    //Still use ?: to do the entire thing on one line
                    Console.WriteLine(firstNumber > secondNumber ? $"Difference: {firstNumber - secondNumber}" : $"Difference: {secondNumber - firstNumber}");
                    //
                    Console.WriteLine("Sum: " + (firstNumber + secondNumber));
                    Console.WriteLine("Product: " + firstNumber * secondNumber);
                    Console.WriteLine("Ratio: " + firstNumber / secondNumber);
                }
            }
        }

        private static void RunExerciseSeven()
        {
            double radius = 0.0;

            Console.Write("Input a radius(positiv): ");
            if (getADecimalFromUser(ref radius))
            {
                if (radius > 0)
                {
                    Console.WriteLine("Cirlce Area: " + (Math.PI * Math.Pow(radius, 2)));
                    Console.WriteLine("Cirlce Volume: " + (4 * Math.PI * Math.Pow(radius, 3)) / 3);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The radius can't be 0 or less!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseEight()
        {
            double usersDecimalNumber = 0.0;

            Console.Write("Input a decimal number: ");

            if (getADecimalFromUser(ref usersDecimalNumber))
            {
                Console.WriteLine("Square root: " + Math.Sqrt(usersDecimalNumber));
                Console.WriteLine("Power of 2: " + Math.Pow(usersDecimalNumber, 2));
                Console.WriteLine("Power of 10: " + Math.Pow(usersDecimalNumber, 10));
            }
        }

        private static void RunExerciseNine()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.Write($"Hello {name} input your birth year (f.ex: 1967): ");
            int birthYear = 0;

            if (getAnIntegerFromUser(ref birthYear))
            {
                int age = DateTime.Now.Year - birthYear;

                if (age >= 18)
                {
                    Console.Write("Do you want order a beer?: ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("A beer has been ordered!");
                    }
                    else
                    {
                        Console.Write("Do you want a coke instead?: ");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            Console.WriteLine("A coke has been served!");
                        }
                        else
                        {
                            Console.WriteLine("There are no more options available!");
                        }
                    }
                }
                else
                {
                    Console.Write("Do you want to order a coke?: ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("A coke has been served!");
                    }
                    else
                    {
                        Console.WriteLine("There are no more options available!");
                    }
                }
            }
        }

        private static void RunExerciseTen()
        {
            Console.Write("Choose between 1 to 3: ");
            int choice = 0;

            if (getAnIntegerFromUser(ref choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Input a number: ");
                        var firstNumber = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("Input another number: ");
                        var secondNumber = int.Parse(Console.ReadLine() ?? "");
                        if (secondNumber != 0)
                        {
                            Console.WriteLine(firstNumber / secondNumber);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: denominator is 0");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        RunExerciseFour();
                        break;
                    case 3:
                        if (forgroundColorUsed == ConsoleColor.Magenta)
                        {
                            forgroundColorUsed = ConsoleColor.Cyan;
                        }
                        else
                        {
                            forgroundColorUsed = ConsoleColor.Magenta;
                        }

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{choice} is not an available option!");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static void RunExerciseEleven()
        {
            Console.Write("Input an integer(aka a number above 0 thats not a decimal): ");

            int number = 0;

            if (getAnIntegerFromUser(ref number))
            {
                if (number > 0)
                {
                    //Loop out the numbers 0 to number in the first loop
                    //Then reversed in the second loop
                    //Change color to red if the number can be divided by 2
                    for (int i = 0; i <= number; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("--------------------------");
                    for (int i = number; i >= 0; i--)
                    {
                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: the number needs to be above 0!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseTwelve()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
            }
        }
        private static void RunExerciseThirteen()
        {
            Random rnd = new Random();

            int randValue = rnd.Next(1, 501);
            int guessedValue = 0;
            int count = 0;
            bool isAlive = true;

            while (isAlive)
            {
                Console.ResetColor();
                Console.Write("Guess a number between 1 and 500: ");

                if (int.TryParse(Console.ReadLine(), out guessedValue))
                {
                    if (guessedValue != randValue)
                    {
                        if (guessedValue > randValue)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Guess a lower number!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Guess a larger number!");
                            Console.ResetColor();
                        }
                        count++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations, you guessed correctly!" +
                            $" It took you {count} tries.");
                        Console.ResetColor();
                        isAlive = false;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: the number needs to be above 0!");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseFourteen()
        {
            int inputValue = 0;
            int sum = 0;
            int count = 0;

            //We use a do while there because the user needs input something before the loop can even exit
            do
            {
                Console.Write("Input a number (input -1 to stop the loop): ");
                if (int.TryParse(Console.ReadLine(), out inputValue))
                {
                    if (inputValue != -1)
                    {
                        sum += inputValue;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Sum of the numbers inputted: " + sum);
                        Console.WriteLine("Average of the numbers inputted: " + sum / count);
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: not a number!");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

            } while (inputValue != -1);

        }

        //Look at Exercise 15 option 2 in the pdf and do that option
        private static void RunExerciseFifteen()
        {
            bool isAlive = true;
            int current = 1;
            int stop = 0;
            int number = 0;

            Console.Write("Input an integer: ");

            if (getAnIntegerFromUser(ref number))
            {
                if (number != 0)
                {
                    if (number < 0) { number *= -1; }
                    stop = number / 2;

                    while (isAlive)
                    {
                        if (number % current == 0)
                        {
                            Console.Write(current + " ");
                        }

                        if (current >= stop)
                        {
                            isAlive = false;
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            current++;
                        }
                    }
                }
            }
        }

        //Ask for the integer and checks so it is an integer, then calls the recursive method.
        private static void RunExerciseSixteen()
        {
            Console.Write("Input an integer and the program will do a Fibonacchi series on it: ");
            int fibonacchiNumber = 0;

            if (getAnIntegerFromUser(ref fibonacchiNumber))
            {
                if (fibonacchiNumber > 0)
                {
                    RunExerciseSixteen(fibonacchiNumber, 0, 0, 1);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: The integer must be above 0!");
                    Console.ResetColor();
                }
            }
        }

        //Fibonacchi method, recursive
        private static bool RunExerciseSixteen(int limit, int count, int firstNumber, int secondNumber)
        {
            Console.Write(firstNumber);
            int tmp = firstNumber;
            firstNumber = secondNumber;
            secondNumber += tmp;
            count++;

            if (limit == count)
            {
                return true;
            }

            Console.Write(", ");

            return RunExerciseSixteen(limit, count, firstNumber, secondNumber);
        }

        private static void RunExerciseSeventeen()
        {
            Console.WriteLine("Type in a palindrome, only the alphabetic letters a-ö is accepted!");
            string input = Console.ReadLine();

            //I split the input string so I can later check each char in it is an alphabetic letter
            //If I just check the whole string at once it returns false if its white space in it.
            //And it should contain white space if the user choose too.
            string[] inputArray = input.Split();
            bool continueOn = true;

            //Here the proram loops through the array to check each index if its an alphabetic letter
            for (int i = 0; i < inputArray.Length; i++)
            {
                //Its like a foreach, x is what contains in i index and  we check if its a letter with char.IsLetter
                if (inputArray[i].Any(x => !char.IsLetter(x)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Contains something other than alphabetic letters!");
                    Console.ResetColor();

                    continueOn = false;
                    break;
                }
            }

            if (continueOn)
            {
                //The program splits to remove all whitespaces then remake the string without them
                string palindrome = "";
                string[] tmp = input.Split(' ');
                for (int i = 0; i < tmp.Length; i++)
                {
                    palindrome += tmp[i].ToString();
                }

                //Removes all uppercase
                palindrome = palindrome.ToLower();

                //Reverse the string and compares
                if (palindrome.SequenceEqual(palindrome.Reverse()))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{input} is a palindrome");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{input} is not a palindrome");
                    Console.ResetColor();
                }
            }
        }

        private static void RunExerciseEighteen()
        {
            int[] intArray = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < intArray.Length;  i++)
            {
                intArray[i] = rnd.Next(1, 101);
            }

            double[] doubleArray = new double[intArray.Length];

            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = 1.0 / intArray[i];
            }

            foreach (var item in intArray)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine("\n");
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExerciseNineteen()
        {
            Random rnd = new Random();
            int cost = rnd.Next(1, 1001);
            int userPayed = 0;

            Console.WriteLine("Money to pay: " + cost);
            Console.Write("Enter the sum to pay: ");
            getAnIntegerFromUser(ref userPayed);

            int toPayBack = userPayed - cost;
            int[] coins =  { 1, 5, 10, 20, 50, 100, 500, 1000 };
            int[] cointsToPay = new int[coins.Length];

            while(toPayBack > 0)
            {
                for (int i = coins.Length-1; i >= 0 ; i--)
                {
                    if (toPayBack / coins[i] != 0)
                    {
                        cointsToPay[i] = toPayBack / coins[i];
                        toPayBack %= coins[i];
                    }
                    Console.WriteLine($"{coins[i]} coins = {cointsToPay[i]}");
                }
            }
        }
        private static void RunExerciseTwenty()
        {

        }

        private static bool getAnIntegerFromUser(ref int value)
        {
            try
            {
                var number = int.Parse(Console.ReadLine() ?? "");
                value = number;

                return true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Not an integer!");
                Console.ResetColor();
            }

            return false;
        }

        private static bool getADecimalFromUser(ref double value)
        {
            try
            {
                var number = double.Parse(Console.ReadLine() ?? "");
                value = number;

                return true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Not an integer!");
                Console.ResetColor();
            }

            return false;
        }
    }
}
