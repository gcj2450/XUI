using UnityEngine;
using System.Collections;
using TMPro;

namespace XUI.Theme.Style
{
    public class XUITmp_TextStyle : XUIBaseStyle
    {
        public TMP_FontAsset font;
        public FontStyles fontStyle = FontStyles.Normal;
        public TextAlignmentOptions alignment = TextAlignmentOptions.TopLeft;
        public Color fontColor = new Color(0.196f, 0.196f, 0.196f, 1);
        public int fontSize = 14;

    }

}