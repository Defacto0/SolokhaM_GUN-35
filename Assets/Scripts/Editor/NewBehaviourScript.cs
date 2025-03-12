using UnityEditor;
using UnityEngine;

public class TestEditor : MonoBehaviour
{
    [InitializeOnLoadMethod]
    static void OnLoad()
    {
        Debug.Log("Editor script loaded!");
    }
}