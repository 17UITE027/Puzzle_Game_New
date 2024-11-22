using UnityEngine;

public class WordGameStateManager : MonoBehaviour
{
    private string constructedSentence = string.Empty;

    public string GetConstructedSentence()
    {
        return constructedSentence;
    }

    public void AddWord(string word)
    {
        Debug.Log("Button Clicked!");
        constructedSentence += (constructedSentence.Length > 0 ? " " : "") + word;
    }

    public void ClearSelection()
    {
        constructedSentence = string.Empty;
    }
}
