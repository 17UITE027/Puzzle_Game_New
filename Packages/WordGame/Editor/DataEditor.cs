using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Data))]
public class DataEditor : Editor
{
    public override void OnInspectorGUI(){
        Data data=(Data)target;

        EditorGUILayout.LabelField("Instruction Text");
        data.instructionText=EditorGUILayout.TextArea(data.instructionText);

        data.buttonCount=EditorGUILayout.IntField("No.of.Words", data.buttonCount);

        EditorGUILayout.LabelField("Words");
        SerializedProperty Words=serializedObject.FindProperty("buttonWords");
        EditorGUILayout.PropertyField(Words, true);

        data.correctSentence=EditorGUILayout.TextField("Correct Sentence",data.correctSentence);

        if(GUI.changed){
            serializedObject.ApplyModifiedProperties(); 
            EditorUtility.SetDirty(data);
            
        }
    }
}
