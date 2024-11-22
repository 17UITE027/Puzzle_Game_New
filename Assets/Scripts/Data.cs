using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Data", menuName="Word Game Tools/Data")]
public class Data : ScriptableObject
{
   [TextArea] public string instructionText;
   public int buttonCount;
   public List<string> buttonWords=new List<string>();
   public string correctSentence;
}
