public class Computer
{
    private ChoiceSelector choiceSelector;

    public Computer()
    {
        choiceSelector = new ChoiceSelector();
    }

    public int GetChoice()
    {
        return choiceSelector.GetComputerChoice();
    }
}
