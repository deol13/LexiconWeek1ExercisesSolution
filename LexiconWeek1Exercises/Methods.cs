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
            
            DateTime todaysDate = DateTime.Now;
            todaysDate = todaysDate.Date;
            DateTime yesterdaysDate = todaysDate.AddDays(-1);
            DateTime tomorrowsDate = todaysDate.AddDays(1);

            Console.WriteLine($"Todays date is {todaysDate.ToString("d")}");
            Console.WriteLine($"Tomorrows date is {tomorrowsDate.ToString("d")}");
            Console.WriteLine($"Yesterdays date was {yesterdaysDate.ToString("d")}");
        }

    }
}
