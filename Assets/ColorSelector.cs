using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelector : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void w1ColorSelector()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
        else if (buttonName == "Blue button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#3A1C15", out myColor);
            band1.color = myColor;
        }
    }

    public void w2ColorSelector()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "Red button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#E70903", out myColor);
            band2.color = myColor;
        }

    }

    public void w3ColorSelector()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#8FACB0", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "Red button")
        {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#FFD700", out myColor);
            band3.color = myColor;
        }

    }
}
