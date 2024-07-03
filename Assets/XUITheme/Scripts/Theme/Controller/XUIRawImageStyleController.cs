using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;

namespace XUI.Theme.StyleController
{

    public class XUIRawImageStyleController : XUIBaseStyleController<UnityUI.RawImage, XUIRawImageStyle>
    {

        public override void ApplyStyle(XUIStyleSheet xSheet)
        {
            if (xSheet == null)
            {
                return;
            }
            UnityUI.RawImage image = mTargetGraphic;
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
            if (xSheet.StyleComponents[styleKey].GetType() != typeof(XUIRawImageStyle))
            {
                Debug.Log($"gameObject: {gameObject.name} config not correct, {xSheet.StyleComponents[styleKey].GetType()} not match {typeof(XUIRawImageStyle)}");
                return;
            }
            XUIRawImageStyle uiStyle = (XUIRawImageStyle)xSheet.StyleComponents[styleKey];
            image.texture = uiStyle.texture;
            image.color = uiStyle.color;
        }

    }

}