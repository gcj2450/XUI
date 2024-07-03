using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;
using TMPro;

namespace XUI.Theme.StyleController
{

    [ExecuteInEditMode]
    public class XUITMP_TextStyleController : XUIBaseStyleController<TMP_Text, XUITmp_TextStyle>
    {

        public override void ApplyStyle(XUIStyleSheet xSheet)
        {
            TMP_Text text = mTargetGraphic;
            if (xSheet.StyleComponents == null || xSheet.StyleComponents.Count == 0)
            {
                return;
            }
            if (!xSheet.StyleComponents.ContainsKey(styleKey))
            {
                return;
            }
            if (xSheet.StyleComponents[styleKey] == null)
            {
                return;
            }
            if (xSheet.StyleComponents.Count == 0 || xSheet.StyleComponents[styleKey].GetType() != typeof(XUITmp_TextStyle))
            {
                Debug.Log($"gameObject: {gameObject.name} config not correct, {xSheet.StyleComponents[styleKey].GetType()} not match {typeof(XUITmp_TextStyle)}");
                return;
            }

            XUITmp_TextStyle uiStyle = (XUITmp_TextStyle)xSheet.StyleComponents[styleKey];

            text.font = uiStyle.font;
            text.fontStyle = uiStyle.fontStyle;
            text.fontSize = uiStyle.fontSize;
            text.alignment = uiStyle.alignment;
            text.color = uiStyle.fontColor;
        }

    }

}