using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XUI.Theme.Style;

public class StyleRandomChanger : MonoBehaviour
{
    public XUIStyleSheetTable StyleSheetTable;

    private void Awake()
    {
        int id = 0;
        id = Random.Range(0, 2);
        StyleSheetTable.ActiveStyle = id;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
