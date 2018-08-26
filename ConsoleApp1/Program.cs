using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();
            

            while (true)
            {

            

            //int correctNumber = 7;

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {

                        PrintColorMessage(ConsoleColor.Red, "Please Enter a Number");
                    

                    continue;
                }

                guess = Int32.Parse(input);

                if(guess != correctNumber)
                {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number please try again");                    

                }
            }

                PrintColorMessage(ConsoleColor.Yellow, "Correct");

            

            Console.WriteLine("Would you like to play Again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }
        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sean White";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your Name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
            

        }
    }
}
