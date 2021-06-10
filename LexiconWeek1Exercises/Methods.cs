using System;
using System.Collections.Generic;
using System.Text;

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
            //If it isn't a number, Parse will use "" which will trigger the catch
            try
            {
                Console.Write("Input a number:");
                var firstNumber = double.Parse(Console.ReadLine() ?? "");
                Console.Write("Input another number:");
                var secondNumber = double.Parse(Console.ReadLine() ?? "");

                //We use ?: operator to check which variable is larger and output that one on one line
                Console.WriteLine(firstNumber > secondNumber ? $"Biggest: {firstNumber}" : $"Biggest: {secondNumber}");
                //Samething but smallest of them
                Console.WriteLine(firstNumber < secondNumber ? $"Smallest: {firstNumber}" : $"Smallest: {secondNumber}");
                //Still use ?: to do the entire thing on one line
                Console.WriteLine(firstNumber > secondNumber ? $"Difference: {firstNumber-secondNumber}" : $"Difference: {secondNumber- firstNumber}");
                //
                Console.WriteLine("Sum: " + (firstNumber + secondNumber));
                Console.WriteLine("Product: " + firstNumber * secondNumber);
                Console.WriteLine("Ratio: " + firstNumber / secondNumber);
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Either input isn't a number!");
                Console.ResetColor();
            }
        }

        private static void RunExerciseSeven()
        {
            try
            {
                Console.Write("Input a radius(positiv): ");
                var radius = double.Parse(Console.ReadLine() ?? "");

                if(radius > 0)
                {
                    Console.WriteLine("Cirlce Area: " + (2 * Math.PI * Math.Pow(radius, 2)));
                    Console.WriteLine("Cirlce Volume: " + (4 * Math.PI * Math.Pow(radius, 3))/3 );
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The radius can't be 0 or less!");
                    Console.ResetColor();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Either input isn't a number!");
                Console.ResetColor();
            }
        }

        private static void RunExerciseEight()
        {
            try
            {
                Console.Write("Input a decimal number: ");
                var usersDecimalNumber = double.Parse(Console.ReadLine() ?? "");

                Console.WriteLine("Square root: " + Math.Sqrt(usersDecimalNumber));
                Console.WriteLine("Power of 2: " + Math.Pow(usersDecimalNumber, 2));
                Console.WriteLine("Power of 10: " + Math.Pow(usersDecimalNumber, 10));
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Either input isn't a number!");
                Console.ResetColor();
            }
        } 

        private static void RunExerciseNine()
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            try
            {
                Console.Write($"Hello {name} input your birth year (f.ex: 1967): ");
                var birthYear = int.Parse(Console.ReadLine() ?? "");

                int age = DateTime.Now.Year - birthYear;

                if(age >= 18)
                {
                    Console.Write("Do you want order a beer?: ");
                    if(Console.ReadLine().ToLower() == "yes")
                    {
                        Console.WriteLine("A beer has been ordered!");
                    }
                    else
                    {
                        Console.Write("Do you want a coke instead?: ");
                        if (Console.ReadLine().ToLower() == "yes" )
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
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Either input isn't a number!");
                Console.ResetColor();
            }
        }

        private static void RunExerciseTen()
        {
            try
            {
                Console.Write("Choose between 1 to 3: ");
                var choice = int.Parse(Console.ReadLine() ?? "");

                switch (choice)
                {
                    case 1:
                        Console.Write("Input a number: ");
                        var firstNumber = int.Parse(Console.ReadLine() ?? "");
                        Console.Write("Input another number: ");
                        var secondNumber = int.Parse(Console.ReadLine() ?? "");
                        if(secondNumber != 0)
                        {
                            Console.WriteLine(firstNumber/secondNumber);
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
                        if(forgroundColorUsed == ConsoleColor.Magenta)
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
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Either input isn't a number!");
                Console.ResetColor();
            }
        }

        private static void RunExerciseEleven()
        {

        }
    }
}
