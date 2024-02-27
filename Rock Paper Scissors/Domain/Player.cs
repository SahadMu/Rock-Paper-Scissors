public class Player
{
    private ChoiceSelector choiceSelector;

    public Player()
    {
        choiceSelector = new ChoiceSelector();
    }

    public int GetChoice()
    {
        return choiceSelector.GetPlayerChoice();
    }
}
