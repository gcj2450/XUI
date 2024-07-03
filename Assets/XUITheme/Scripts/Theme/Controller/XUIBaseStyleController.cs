using UnityEngine;
using UnityUI = UnityEngine.UI;
using System.Collections;
using XUI.Theme.Style;

namespace XUI.Theme.StyleController
{

    [ExecuteInEditMode]
    public abstract class XUIBaseStyleController<UNITY_GRAPHIC, STYLE> : MonoBehaviour
        where UNITY_GRAPHIC : UnityUI.Graphic
        where STYLE : XUIBaseStyle
    {
        [HideInInspector]
        public string styleKey = "";
        [HideInInspector]
        public int selectedIndex = 0;
        public XUIStyleSheetTable styleTable;
        protected UNITY_GRAPHIC mTargetGraphic;

        void Awake()
        {
            UNITY_GRAPHIC g = GetComponent<UNITY_GRAPHIC>();
            if (g == null)
            {
                Destroy(this);
                return;
            }
            mTargetGraphic = g;
        }

        void Start()
        {
            if (styleTable != null &&
                styleTable.StyleStyleSheets != null &&
                styleTable.ActiveStyle < styleTable.StyleStyleSheets.Count &&
                styleTable.StyleStyleSheets[styleTable.ActiveStyle] != null)
            {
                ApplyStyle(styleTable.StyleStyleSheets[styleTable.ActiveStyle]);
            }
        }

#if UNITY_EDITOR
        void Update()
        {
            if (styleTable != null &&
                styleTable.StyleStyleSheets != null &&
                styleTable.ActiveStyle < styleTable.StyleStyleSheets.Count &&
                styleTable.StyleStyleSheets[styleTable.ActiveStyle] != null)
            {
                ApplyStyle(styleTable.StyleStyleSheets[styleTable.ActiveStyle]);
            }
        }
#endif

        public virtual void ApplyStyle(XUIStyleSheet _styleSheet)
        {
            throw new System.NotImplementedException();
        }
    }

}