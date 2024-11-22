
public class SelectWordCommand : ICommand
{
    private WordGameStateManager stateManager;
    private string word;

    public SelectWordCommand(WordGameStateManager stateManager, string word)
    {
        this.stateManager = stateManager;
        this.word = word;
    }

    public void Execute()
    {
        stateManager.AddWord(word);
    }
}