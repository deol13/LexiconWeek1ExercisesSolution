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

                    Console.Clear();
                    switch (exerciseChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            RunExerciseFifteen();
                            break;
                        case 16:
                            RunExerciseSixteen();
                            break;
                        case 17:
                            RunExerciseSeventeen();
                            break;
                        case 18:
                            RunExerciseEighteen();
                            break;
                        case 19:;
                            RunExerciseNineteen();
                            break;
                        case 20:
                            RunExerciseTwenty();
                            break;
                        case 21:
                            RunExerciseTwentyone();
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
                    Console.WriteLine("\n");
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