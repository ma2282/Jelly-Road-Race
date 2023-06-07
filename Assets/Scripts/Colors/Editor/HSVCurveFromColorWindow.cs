using Newtonsoft.Json;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEditor;
using UnityEngine;

namespace Game.Gameplay
{
    public class HSVCurveFromColorWindow : EditorWindow
    {
        private Color inputColor;
        private AnimationCurve resultCurve;

        [MenuItem("Window/Get HSV curve from color")]
        public static void ShowWindow()
        {
            GetWindow(typeof(HSVCurveFromColorWindow));
        }

        private void OnGUI()
        {
            inputColor = EditorGUILayout.ColorField("Input Color", inputColor);

            if (GUILayout.Button("Get HSV Curve"))
                resultCurve = HSVCurveFromColor.GetHSVCurve(inputColor);

            EditorGUILayout.Space();
            
            EditorGUILayout.CurveField("Result Curve", resultCurve);
        }
    }
}