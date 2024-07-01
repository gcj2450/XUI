using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace XUI.Theme.Style
{
    /// <summary>
    /// 一个XUStyleSheet可以包含一个预制体或者一个UI界面所包含的所有UIStyle，用于方便管理
    /// </summary>
    public class XUIStyleSheet : ScriptableObject
    {
        [SerializeField]
        public List<StyleComponent> Styles = new List<StyleComponent>();
    }

    [Serializable]
    public class StyleComponent
    {
        public string Name = "";
        public XUIBaseStyle Style;
    }

}