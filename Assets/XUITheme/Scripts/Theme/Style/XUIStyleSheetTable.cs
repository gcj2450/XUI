using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XUI.Theme.Style
{
    /// <summary>
    /// 多个风格列表，用于动态切换风格
    /// </summary>
    public class XUIStyleSheetTable : ScriptableObject
    {
        /// <summary>
        /// 当前激活使用的风格
        /// </summary>
        public int ActiveStyle = 0;

        /// <summary>
        /// 多个风格切换
        /// </summary>
        [SerializeField]
        public List<XUIStyleSheet> StyleStyleSheets = new List<XUIStyleSheet>();
    }
}