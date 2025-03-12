using UnityEditor;
using UnityEngine;

namespace Assets.Editor
{
    public class TestEditor : MonoBehaviour
    {
        [InitializeOnLoadMethod]
        static void OnLoad()
        {
            Debug.Log("Editor script loaded!");
        }
    }
}