public class ChoiceSelector
{
    private Random random;

    public ChoiceSelector()
    {
        random = new Random();
    }

    public int GetPlayerChoice()
    {
        Console.WriteLine("Select your choice:");
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

    public int GetComputerChoice()
    {
        return random.Next(1, 4);
    }
}
