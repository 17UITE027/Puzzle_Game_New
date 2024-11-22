using UnityEngine;

public class WordGameController : MonoBehaviour
{
    [SerializeField] private WordGameStateManager stateManager;
    [SerializeField] private WordGameValidator validator;
    [SerializeField] private WordGameView view;
    [SerializeField] private Data data;

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        view.SetInstructionText(data.instructionText);
        view.CreateWordButtons(data.buttonCount, data.buttonWords, HandleWordSelection);
    }

    public void HandleWordSelection(string word)
    {
        stateManager.AddWord(word);
        bool isCorrect = validator.ValidateSentence(stateManager.GetConstructedSentence());
        view.DisplayResult(isCorrect);
    }

    public void ClearSelection()
    {
        stateManager.ClearSelection();
        view.SwitchBackground(false); // Reset to the first background
    }
}
