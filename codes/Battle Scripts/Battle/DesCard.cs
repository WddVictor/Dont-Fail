using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesCard : MonoBehaviour {

    public static DesCard _instance;

    private UISprite sprite;

    private void Awake(){
        _instance = this;
        this.gameObject.SetActive(false);
    }

    public void ShowCard(string strCost, string strName, string strDescription)
    {
        this.transform.Find("cost").gameObject.GetComponent<UILabel>().text = strCost;
        this.transform.Find("name").gameObject.GetComponent<UILabel>().text = strName;
        this.transform.Find("description").gameObject.GetComponent<UILabel>().text = strDescription;
        this.gameObject.SetActive(true);
    }

    public void NotShowCard()
    {
        this.gameObject.SetActive(false);
    }
}
