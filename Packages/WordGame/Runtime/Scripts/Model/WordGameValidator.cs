using UnityEngine;

public class WordGameValidator : MonoBehaviour
{
    [SerializeField] private Data data;

    public bool ValidateSentence(string constructedSentence)
    {
        return constructedSentence == data.correctSentence;
    }
}
