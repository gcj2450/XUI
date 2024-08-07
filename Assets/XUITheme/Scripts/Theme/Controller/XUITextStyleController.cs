﻿using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;


namespace XUI.Theme.StyleController
{

    [ExecuteInEditMode]
    public class XUITextStyleController : XUIBaseStyleController<UnityUI.Text, XUITextStyle>
    {

        public override void ApplyStyle(XUIStyleSheet xSheet)
        {
            UnityUI.Text text = mTargetGraphic;
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
            if (xSheet.StyleComponents[styleKey].GetType() != typeof(XUITextStyle))
            {
                Debug.Log($"gameObject: {gameObject.name} config not correct, {xSheet.StyleComponents[styleKey].GetType()} not match {typeof(XUITextStyle)}");
                return;
            }

            XUITextStyle uiStyle = (XUITextStyle)xSheet.StyleComponents[styleKey];

            text.font = uiStyle.font;
            text.alignment = uiStyle.alignment;
            text.fontStyle = uiStyle.fontStyle;
            text.lineSpacing = uiStyle.lineSpacing;
            text.fontSize = uiStyle.fontSize;
            text.color = uiStyle.fontColor;
            text.horizontalOverflow = uiStyle.horizontalWrapMode;
            text.verticalOverflow = uiStyle.verticalWrapMode;
        }

    }

}