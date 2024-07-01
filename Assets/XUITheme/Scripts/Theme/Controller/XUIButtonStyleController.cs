using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;
using UnityEngine.UI;

namespace XUI.Theme.StyleController {

    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(Button))]
    public class XUIButtonStyleController : XUIBaseStyleController<UnityUI.Image, XUIButtonStyle> {

        public override void ApplyStyle() {
            UnityUI.Image image = mTargetGraphic;
            
            UnityEngine.UI.Button button = image.GetComponent<UnityEngine.UI.Button>();
            button.targetGraphic = image;
            image.sprite = style.buttonSprite;

            button.transition = style.buttonTransition;
            if (button.transition== Selectable.Transition.ColorTint)
            {
                button.colors = style.buttonColorState;
            }
            else if (button.transition == Selectable.Transition.SpriteSwap)
            {
                button.spriteState = style.buttonSpriteState;
            }
        }

    }

}