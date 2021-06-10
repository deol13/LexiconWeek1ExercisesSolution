using System;

namespace LexiconWeek1Exercises
{
    public partial class Program
    {
        static ConsoleColor forgroundColorUsed = ConsoleColor.Magenta;

        static void Main(string[] args)
        {
            bool isAlive = true;

            
            while (isAlive)
            {
                try
                {
                    changeForgroundColor();

                    Console.Write("Welcome to the menu for week 1 exercises!" +
                        "\n Enter exercise number (or 99 to exit): ");

                    var exerciseChoice = int.Parse(Console.ReadLine() ?? "");
                    //int.TryParse(Console.ReadLine(), out int exerciseChoice);
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
                            RunExerciseThree();
                            break;
                        case 4:
                            Console.Clear();
                            RunExerciseFour();
                            break;
                        case 5:
                            Console.Clear();
                            RunExerciseFive();
                            break;
                        case 6:
                            Console.Clear();
                            RunExerciseSix();
                            break;
                        case 7:
                            Console.Clear();
                            RunExerciseSeven();
                            break;
                        case 8:
                            Console.Clear();
                            RunExerciseEight();
                            break;
                        case 9:
                            Console.Clear();
                            RunExerciseNine();
                            break;
                        case 10:
                            Console.Clear();
                            RunExerciseTen();
                            break;
                        case 11:
                            Console.Clear();
                            RunExerciseEleven();
                            break;
                        case 12:
                            Console.Clear();
                            RunExerciseTwelve();
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

        static void changeForgroundColor()
        {
                Console.ForegroundColor = forgroundColorUsed;
        }
    }
}