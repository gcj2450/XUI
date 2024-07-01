using UnityEngine;
using System.Collections;

namespace XUI.Theme.Style {

    public class XUITextStyle : XUIBaseStyle {

        public Font font;
        public FontStyle fontStyle=FontStyle.Normal;
        public float lineSpacing = 1;
        public Color fontColor=new Color(0.196f, 0.196f, 0.196f,1);
        public int fontSize=14;
        /// <summary>
        /// 文本对齐方式
        /// </summary>
        public TextAnchor alignment=TextAnchor.UpperLeft;
        public HorizontalWrapMode horizontalWrapMode=HorizontalWrapMode.Wrap;
        public VerticalWrapMode verticalWrapMode = VerticalWrapMode.Truncate;

    }


}