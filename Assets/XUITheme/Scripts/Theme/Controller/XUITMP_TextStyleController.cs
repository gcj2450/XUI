using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;
using TMPro;

namespace XUI.Theme.StyleController {

    [ExecuteInEditMode]
    public class XUITMP_TextStyleController : XUIBaseStyleController<TMP_Text, XUITmp_TextStyle> {
        
        public override void ApplyStyle() {
            TMP_Text text = mTargetGraphic;
            text.font = style.font;
            text.fontStyle = style.fontStyle;
            text.fontSize = style.fontSize;
            text.alignment = style.alignment;
            text.color = style.fontColor;
        }

    }

}