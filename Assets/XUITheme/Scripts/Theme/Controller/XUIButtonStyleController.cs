using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;
using UnityEngine.UI;

namespace XUI.Theme.StyleController
{

    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(Button))]
    public class XUIButtonStyleController : XUIBaseStyleController<UnityUI.Image, XUIButtonStyle>
    {

        public override void ApplyStyle(XUIStyleSheet xSheet)
        {
            UnityUI.Image image = mTargetGraphic;

            if (xSheet.StyleComponents[styleKey].GetType() != typeof(XUIButtonStyle))
            {
                Debug.Log($"{xSheet.StyleComponents[styleKey].GetType()} not match {typeof(XUIButtonStyle)}");
                return;
            }

            XUIButtonStyle uiStyle = (XUIButtonStyle)xSheet.StyleComponents[styleKey];

            UnityEngine.UI.Button button = image.GetComponent<UnityEngine.UI.Button>();
            button.targetGraphic = image;
            image.sprite = uiStyle.buttonSprite;

            button.transition = uiStyle.buttonTransition;
            if (button.transition == Selectable.Transition.ColorTint)
            {
                button.colors = uiStyle.buttonColorState;
            }
            else if (button.transition == Selectable.Transition.SpriteSwap)
            {
                button.spriteState = uiStyle.buttonSpriteState;
            }
        }

    }

}