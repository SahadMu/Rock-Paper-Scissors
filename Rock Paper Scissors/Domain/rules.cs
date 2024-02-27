public static class rules
{
    public static void ShowRules()
    {
        Console.WriteLine("\nRules of Rock Paper Scissors:");
        Console.WriteLine("Rock beats Scissors");
        Console.WriteLine("Scissors beats Paper");
        Console.WriteLine("Paper beats Rock");
    }

    public static string GetChoiceName(int choice)
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
