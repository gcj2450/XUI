using UnityEngine;
using UnityUI = UnityEngine.UI;

using System.Collections;

using XUI.Theme.Style;

namespace XUI.Theme.StyleController {

    public class XUIRawImageStyleController : XUIBaseStyleController<UnityUI.RawImage, XUIRawImageStyle> {

        public override void ApplyStyle() {
            UnityUI.RawImage image = mTargetGraphic;
            image.texture = style.texture;
            image.color = style.color;
        }

    }

}