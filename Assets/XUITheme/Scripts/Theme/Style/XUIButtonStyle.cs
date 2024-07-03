using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace XUI.Theme.Style
{

    public class XUIButtonStyle : XUIBaseStyle
    {

        public Selectable.Transition buttonTransition = Selectable.Transition.ColorTint;
        public Sprite buttonSprite;
        public SpriteState buttonSpriteState;
        public ColorBlock buttonColorState = ColorBlock.defaultColorBlock;
    }

}