public class rockPaperScissorsGame
{
    private int roundsToWin;
    private Player player;
    private Computer computer;

    public rockPaperScissorsGame()
    {
        player = new Player();
        computer = new Computer();
    }

    public void Play()
    {
        Console.WriteLine("\nEnter the number of rounds (1, 3, 5) for the match:");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out roundsToWin) || (roundsToWin != 1 && roundsToWin != 3 && roundsToWin != 5))
            {
                Console.WriteLine("Invalid choice. Please enter 1, 3, or 5.");
            }
            else
            {
                break;
            }
        }

        int playerScore = 0;
        int computerScore = 0;

        while (playerScore < roundsToWin && computerScore < roundsToWin)
        {
            Console.WriteLine($"\nPlayer: {playerScore} | Computer: {computerScore}");

            int playerChoice = player.GetChoice();

            int computerChoice = computer.GetChoice();

            Console.WriteLine($"\nYou chose: {rules.GetChoiceName(playerChoice)}");
            Console.WriteLine($"Computer chose: {rules.GetChoiceName(computerChoice)}");

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
                Console.WriteLine("Computer wins the round!");
                computerScore++;
            }

        }

        Console.WriteLine("\nMatch Result:");
        Console.WriteLine($"Player: {playerScore} | Computer: {computerScore}");

        if (playerScore > computerScore)
        {
            Console.WriteLine("You win the match!");
        }
        else if (playerScore < computerScore)
        {
            Console.WriteLine("Computer wins the match!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
