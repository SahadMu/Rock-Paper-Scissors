using System;
using System.Threading;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock Paper Scissors!");

        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Start Playing");
            Console.WriteLine("2. Rules");
            Console.WriteLine("3. Quit");

            int choice;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                }
                else
                {
                    break;
                }
            }

            switch (choice)
            {
                case 1:
                    rockPaperScissorsGame game = new rockPaperScissorsGame();
                    game.Play();
                    break;
                case 2:
                    rules.ShowRules();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    return;
            }
        }
    }
}
