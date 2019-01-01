using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIInfo : MonoBehaviour
{
    public GameObject TextContent;
   
    public void OnHover(bool isHover)
    {
        if (isHover)
        {
            ShowText();
        }
        else
        {
            HideText();
        }
    }

    public void ShowText()
    {
        TextContent.SetActive(true);
    }

    public void HideText()
    {
        TextContent.SetActive(false);
    }
}