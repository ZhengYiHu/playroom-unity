using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class PlayroomVariablesViewer : MonoBehaviour
{
    [SerializeField]
    Text text;

    void Update()
    {
        text.text = "";
        FieldInfo mockDictionaryFieldInfo = typeof(Playroom.PlayroomKit).GetField("MockDictionary", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);

        Dictionary<string, object> mockDictionary = (Dictionary<string, object>) mockDictionaryFieldInfo.GetValue(null);
        foreach (var entry in mockDictionary)
        {
            text.text += entry.ToString() + "\n";
        }

    }
}
