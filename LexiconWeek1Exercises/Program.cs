using System;

namespace LexiconWeek1Exercises
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            bool isAlive = true;

            while (isAlive)
            {
                try
                {
                    Console.WriteLine("Welcome to the menu for week 1 exercises!" +
                        "\n 1: " +
                        "\n 2: " +
                        "\n 3: " +
                        "\n 4: " +
                        "\n 5: " +
                        "\n 5: " +
                        "\n 6: " +
                        "\n 99: Exit");

                    int.TryParse(Console.ReadLine(), out int exerciseChoice);
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (exerciseChoice)
                    {
                        case 1:
                            Console.Clear();
                            RunExerciseOne();
                            break;
                        case 2:
                            Console.Clear();
                            RunExerciseTwo();
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
                            Console.Clear();
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        case 99:
                            Console.WriteLine("Thank you for trying my program!");
                            isAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid exercise number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a valid exercise number!");
                    Console.ResetColor();
                }
            }
        }
    }
}
