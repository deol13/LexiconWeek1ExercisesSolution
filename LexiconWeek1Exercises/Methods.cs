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
            todaysDate = todaysDate.Date;
            //Then we get yesterdays date by using AddDays with an negativ 1 as argument
            //And tomorrows by using a positiv 1 as an argument
            DateTime yesterdaysDate = todaysDate.AddDays(-1);
            DateTime tomorrowsDate = todaysDate.AddDays(1);

            Console.WriteLine($"Todays date is {todaysDate.ToString("d")}");
            Console.WriteLine($"Tomorrows date is {tomorrowsDate.ToString("d")}");
            Console.WriteLine($"Yesterdays date was {yesterdaysDate.ToString("d")}");
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

        }

        private static void RunExerciseSix()
        {

        }
    }
}
