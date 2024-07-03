using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace XUI.Theme.Style
{
    /// <summary>
    /// 一个XUStyleSheet代表一种风格，
    /// 可以包含一个预制体或者一个UI界面所包含的所有UIStyle，用于方便管理
    /// </summary>
    public class XUIStyleSheet : ScriptableObject
    {
        /// <summary>
        /// 当前风格包含的所有UI组件
        /// </summary>
        [SerializeField]
        public SerializableDictionaryBase<string, XUIBaseStyle> StyleComponents = 
            new SerializableDictionaryBase<string, XUIBaseStyle>();
    }

}