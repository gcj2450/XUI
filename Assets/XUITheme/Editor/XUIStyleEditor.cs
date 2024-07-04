using UnityEngine;
using UnityUI = UnityEngine.UI;
using UnityEditor;

using System.IO;
using System.Collections;

using XUI.Theme.Style;
using XUI.Theme.StyleController;
using TMPro;


namespace XUIEditor
{

    public class XUIStyleEditor : EditorWindow
    {

        const string kResourceFolderName = "Resources";
        const string kXUIStyleFolder = "XUIStyles";
        const string kXUIStyleDirectoryPath = "Assets/Resources/XUIStyles/";

        [MenuItem("XUIStyle/Add Style/TMP_Text")]
        [MenuItem("CONTEXT/TMP_Text/Attach XUIStyle")]
        static void AttachTMP_TextStyle()
        {
            GameObject selectedGO = Selection.activeObject as GameObject;
            if (selectedGO == null)
            {
                return;
            }

            TMP_Text image = selectedGO.GetComponent<TMP_Text>();
            if (image == null)
            {
                EditorUtility.DisplayDialog("Attach failed!", "Cannot attached TMP_Text style to Non-TMP_Text component", "Ok");
                return;
            }

            XUITMP_TextStyleController controller = selectedGO.GetComponent<XUITMP_TextStyleController>();
            if (controller != null)
            {
                EditorUtility.DisplayDialog("Already attached!", "This GameObject has already been attach TMP_TextStyleController.", "Ok");
                return;
            }
            selectedGO.AddComponent<XUITMP_TextStyleController>();
        }

        [MenuItem("XUIStyle/Add Style/Text")]
        [MenuItem("CONTEXT/Text/Attach XUIStyle", false)]
        static void AttachTextStyle()
        {
            GameObject selectedGO = Selection.activeObject as GameObject;
            if (selectedGO == null)
            {
                return;
            }

            UnityUI.Text text = selectedGO.GetComponent<UnityUI.Text>();
            if (text == null)
            {
                EditorUtility.DisplayDialog("Attach failed!", "Cannot attached Text style to Non-Text component", "Ok");
                return;
            }

            XUITextStyleController controller = selectedGO.GetComponent<XUITextStyleController>();
            if (controller != null)
            {
                EditorUtility.DisplayDialog("Already attached!", "This GameObject has already attached TextStyleController.", "Ok");
                return;
            }
            selectedGO.AddComponent<XUITextStyleController>();
        }

        [MenuItem("XUIStyle/Add Style/Image")]
        [MenuItem("CONTEXT/Image/Attach XUIStyle")]
        static void AttachImageStyle()
        {
            GameObject selectedGO = Selection.activeObject as GameObject;
            if (selectedGO == null)
            {
                return;
            }

            UnityUI.Image image = selectedGO.GetComponent<UnityUI.Image>();
            if (image == null)
            {
                EditorUtility.DisplayDialog("Attach failed!", "Cannot attached Image style to Non-Image component", "Ok");
                return;
            }

            XUIImageStyleController controller = selectedGO.GetComponent<XUIImageStyleController>();
            if (controller != null)
            {
                EditorUtility.DisplayDialog("Already attached!", "This GameObject has already been attach ImageStyleController.", "Ok");
                return;
            }
            selectedGO.AddComponent<XUIImageStyleController>();
        }

        [MenuItem("XUIStyle/Add Style/RawImage")]
        [MenuItem("CONTEXT/RawImage/Attach XUIStyle")]
        static void AttachRawImageStyle()
        {
            GameObject selectedGO = Selection.activeObject as GameObject;
            if (selectedGO == null)
            {
                return;
            }

            UnityUI.RawImage image = selectedGO.GetComponent<UnityUI.RawImage>();
            if (image == null)
            {
                EditorUtility.DisplayDialog("Attach failed!", "Cannot attached RawImage style to Non-RawImage component", "Ok");
                return;
            }

            XUIRawImageStyleController controller = selectedGO.GetComponent<XUIRawImageStyleController>();
            if (controller != null)
            {
                EditorUtility.DisplayDialog("Already attached!", "This GameObject has already been attach RawImageStyleController.", "Ok");
                return;
            }
            selectedGO.AddComponent<XUIRawImageStyleController>();
        }

        [MenuItem("XUIStyle/Add Style/Button")]
        [MenuItem("CONTEXT/Button/Attach XUIStyle")]
        static void AttachButtonStyle()
        {
            GameObject selectedGO = Selection.activeObject as GameObject;
            if (selectedGO == null)
            {
                return;
            }

            UnityUI.Button image = selectedGO.GetComponent<UnityUI.Button>();
            if (image == null)
            {
                EditorUtility.DisplayDialog("Attach failed!", "Cannot attached Button style to Non-Button component", "Ok");
                return;
            }

            XUIButtonStyleController controller = selectedGO.GetComponent<XUIButtonStyleController>();
            if (controller != null)
            {
                EditorUtility.DisplayDialog("Already attached!", "This GameObject has already been attach ButtonStyleController.", "Ok");
                return;
            }
            selectedGO.AddComponent<XUIButtonStyleController>();
        }

        [MenuItem("XUIStyle/Create Style/TMP_Text")]
        static void CreateTMP_TextStyle()
        {
            XUITmp_TextStyle asset = CreateStyleAsset<XUITmp_TextStyle>("TMP_TextStyle");
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/Text")]
        static void CreateTextStyle()
        {
            XUITextStyle asset = CreateStyleAsset<XUITextStyle>("TextStyle");
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/Image")]
        static void CreateImageStyle()
        {
            XUIImageStyle asset = CreateStyleAsset<XUIImageStyle>("ImageStyle");
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/RawImage")]
        static void CreateRawImageStyle()
        {
            XUIRawImageStyle asset = CreateStyleAsset<XUIRawImageStyle>("RawImageStyle");
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/Button")]
        static void CreateButtonStyle()
        {
            XUIButtonStyle asset = CreateStyleAsset<XUIButtonStyle>("ButtonStyle");
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/StyleSheet")]
        static void CreateStyleSheet()
        {
            CreateStyleDirectoryIfNotExist();
            string styleAssetPath = Path.Combine(kXUIStyleDirectoryPath, "StyleSheet.asset");
            styleAssetPath = AssetDatabase.GenerateUniqueAssetPath(styleAssetPath);
            XUIStyleSheet asset = ScriptableObject.CreateInstance<XUIStyleSheet>();
            AssetDatabase.CreateAsset(asset, styleAssetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        [MenuItem("XUIStyle/Create Style/StyleSheetTable")]
        static void CreateStyleSheetTable()
        {
            CreateStyleDirectoryIfNotExist();
            string styleAssetPath = Path.Combine(kXUIStyleDirectoryPath, "StyleSheetTable.asset");
            styleAssetPath = AssetDatabase.GenerateUniqueAssetPath(styleAssetPath);
            XUIStyleSheetTable asset = ScriptableObject.CreateInstance<XUIStyleSheetTable>();
            AssetDatabase.CreateAsset(asset, styleAssetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = asset;
        }

        static STYLE CreateStyleAsset<STYLE>(string assetName) where STYLE : XUIBaseStyle
        {
            CreateStyleDirectoryIfNotExist();
            string styleAssetPath = Path.Combine(kXUIStyleDirectoryPath, assetName + ".asset");
            styleAssetPath = AssetDatabase.GenerateUniqueAssetPath(styleAssetPath);
            STYLE asset = ScriptableObject.CreateInstance<STYLE>();
            AssetDatabase.CreateAsset(asset, styleAssetPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return asset;
        }

        static void CreateStyleDirectoryIfNotExist()
        {
            string rootPath = Application.dataPath;

            string resourceDirPath = Path.Combine(rootPath, "Resources");
            if (!Directory.Exists(resourceDirPath))
            {
                Directory.CreateDirectory(resourceDirPath);
                AssetDatabase.Refresh();
            }

            string styleDirPath = Path.Combine(resourceDirPath, "XUIStyles");
            if (!Directory.Exists(styleDirPath))
            {
                Directory.CreateDirectory(styleDirPath);
                AssetDatabase.Refresh();
            }
        }
    }
}