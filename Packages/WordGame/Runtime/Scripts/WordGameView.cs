using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class WordGameView : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI instructionText;
    [SerializeField] private GameObject wordButtonPrefab;
    [SerializeField] private Transform wordButtonContainer;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private TextMeshProUGUI currentSelectionText;

    [Header("Backgrounds")]
    [SerializeField] private GameObject background1;
    [SerializeField] private GameObject background2;

    public void SetInstructionText(string text)
    {
        Debug.Log("Setting instruction text to: " + text);
        instructionText.text = text;
    }

    public void CreateWordButtons(int buttonCount, List<string> words, System.Action<string> onWordSelected)
    {
        Debug.Log(buttonCount);
        Debug.Log($"Word Count : {words.Count}");
        
        foreach (Transform child in wordButtonContainer)
        {
            Debug.Log($"Hello");
            Destroy(child.gameObject);
        }

        buttonCount = Mathf.Min(buttonCount, words.Count);

        for (int i = 0; i < buttonCount; i++)
        {
            GameObject buttonObj = Instantiate(wordButtonPrefab, wordButtonContainer);
            Button button = buttonObj.GetComponent<Button>();
            TextMeshProUGUI buttonText = buttonObj.GetComponentInChildren<TextMeshProUGUI>();

            buttonText.text = words[i];

            int index=i;
            
            button.onClick.AddListener(() =>
            {
                currentSelectionText.text = words[index];
                
                onWordSelected(words[index]);
            });
        }
        
    }


    public void DisplayResult(bool isCorrect)
    {
        resultText.text = isCorrect ? "Correct!" : "Incorrect.";
        resultText.color = isCorrect ? Color.green : Color.red;

        if (isCorrect)
        {
            SwitchBackground(true);
            instructionText.gameObject.SetActive(false);
            wordButtonContainer.gameObject.SetActive(false);
        }
    }

    public void SwitchBackground(bool useSecondBackground)
    {

        background1.SetActive(!useSecondBackground);
        background2.SetActive(useSecondBackground);
    }
    
}
