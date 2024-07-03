using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using XUI.Theme.Style;
using XUI.Theme.StyleController;

namespace XUIEditor
{
    [CustomEditor(typeof(XUIButtonStyleController))]
    public class XUIButtonStyleControllerInspector : UnityEditor.Editor
    {
        XUIButtonStyleController config;

        private void OnEnable()
        {
            config = (XUIButtonStyleController)target;
        }
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            XUIStyleSheet _styleSheet;
            if (config.styleTable != null &&
                config.styleTable.StyleStyleSheets != null &&
                config.styleTable.ActiveStyle < config.styleTable.StyleStyleSheets.Count &&
                config.styleTable.StyleStyleSheets[config.styleTable.ActiveStyle] != null)
            {
                _styleSheet = config.styleTable.StyleStyleSheets[config.styleTable.ActiveStyle];

                if (_styleSheet != null)
                {
                    List<string> keys = _styleSheet.StyleComponents.Keys.ToList();
                    if (keys != null && keys.Count > 0 && keys.Count > config.selectedIndex)
                    {
                        // Display a dropdown list
                        config.selectedIndex = EditorGUILayout.Popup("Style Name", config.selectedIndex, keys.ToArray());
                        config.styleKey = keys[config.selectedIndex];
                    }
                    else
                    {
                        EditorGUILayout.HelpBox("XUIStyleSheet is empty or no StyleComponents. Assign XUIStyleSheet and add StyleComponents first.", MessageType.Warning);
                    }
                }
            }
            else
            {
                EditorGUILayout.HelpBox("styleTable is empty or no StyleStyleSheets, or ActiveStyle>StyleStyleSheets.count, or StyleStyleSheets[ActiveStyle] is null", MessageType.Warning);
            }

            //// Save the changes back to the ScriptableObject
            //if (GUI.changed)
            //{
            //    styleKey=;
            //}
        }
    }
}