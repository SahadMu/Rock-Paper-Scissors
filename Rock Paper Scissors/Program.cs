using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock Paper Scissors!");

        // Create an instance of the game with Sandra as the computer's name
        RockPaperScissorsGame game = new RockPaperScissorsGame("Sarmad");

        // Start the game
        game.Start();

        Console.WriteLine("\nThanks for playing!");
    }
}

public class RockPaperScissorsGame
{
    private int playerScore;
    private int computerScore;
    private string computerName;

    public RockPaperScissorsGame(string computerName)
    {
        playerScore = 0;
        computerScore = 0;
        this.computerName = computerName;
    }

    public void Start()
    {
        // Game loop until either the player or the computer scores 3 points
        while (playerScore < 3 && computerScore < 3)
        {
            Console.WriteLine($"\nPlayer's Score: {playerScore} | {computerName}'s Score: {computerScore}");

            // Get the player's choice
            Player player = new Player();
            int playerChoice = player.GetChoice();

            // Generate the computer's choice
            Computer computer = new Computer();
            int computerChoice = computer.GetChoice();

            // Display choices
            Console.WriteLine($"\nYou chose: {player.GetChoiceName(playerChoice)}");
            Console.WriteLine($"{computerName} chose: {computer.GetChoiceName(computerChoice)}");

            // Determine the winner of the round
            if ((playerChoice == 1 && computerChoice == 3) ||
                (playerChoice == 2 && computerChoice == 1) ||
                (playerChoice == 3 && computerChoice == 2))
            {
                Console.WriteLine("You win the round!");
                playerScore++;
            }
            else if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else
            {
                Console.WriteLine($"{computerName} wins the round!");
                computerScore++;
            }
        }

        // Determine the winner of the game
        if (playerScore > computerScore)
        {
            Console.WriteLine("\nYou win the game!");
        }
        else
        {
            Console.WriteLine($"\n{computerName} wins the game!");
        }
    }
}

public class Player
{
    public int GetChoice()
    {
        Console.WriteLine("\nSelect your choice:");
        Console.WriteLine("1. Rock");
        Console.WriteLine("2. Paper");
        Console.WriteLine("3. Scissors");

        int playerChoice;
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out playerChoice) || playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
            else
            {
                break;
            }
        }
        return playerChoice;
    }

    public string GetChoiceName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return "Invalid choice";
        }
    }
}

public class Computer
{
    public int GetChoice()
    {
        Random random = new Random();
        return random.Next(1, 4);
    }

    public string GetChoiceName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return "Invalid choice";
        }
    }
}
