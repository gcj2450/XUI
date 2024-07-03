using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;

namespace XUI.Theme.StyleController
{

    public class XUIImageStyleController : XUIBaseStyleController<UnityUI.Image, XUIImageStyle>
    {

        public override void ApplyStyle(XUIStyleSheet xSheet)
        {
            UnityUI.Image image = mTargetGraphic;

            if (xSheet.StyleComponents[styleKey].GetType() != typeof(XUIImageStyle))
            {
                Debug.Log($"{xSheet.StyleComponents[styleKey].GetType()} not match {typeof(XUIImageStyle)}");
                return;
            }

            XUIImageStyle uiStyle = (XUIImageStyle)xSheet.StyleComponents[styleKey];

            image.sprite = uiStyle.sprite;
            image.color = uiStyle.color;
        }

    }

}