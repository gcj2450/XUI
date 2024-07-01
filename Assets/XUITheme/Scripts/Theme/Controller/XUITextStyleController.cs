﻿using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;


namespace XUI.Theme.StyleController {

    [ExecuteInEditMode]
    public class XUITextStyleController : XUIBaseStyleController<UnityUI.Text, XUITextStyle> {
        
        public override void ApplyStyle() {
            UnityUI.Text text = mTargetGraphic;
            text.font = style.font;
            text.alignment = style.alignment;
            text.fontStyle = style.fontStyle;
            text.lineSpacing = style.lineSpacing;
            text.fontSize = style.fontSize;
            text.color = style.fontColor;
            text.horizontalOverflow = style.horizontalWrapMode;
            text.verticalOverflow = style.verticalWrapMode;
        }

    }

}