using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTrigger : MonoBehaviour
{
    public void OnHover(bool isHover)
    {
        if (isHover)
        {
            DesCard._instance.ShowCard(
                this.transform.Find("cost").gameObject.GetComponent<UILabel>().text,
                this.transform.Find("name").gameObject.GetComponent<UILabel>().text,
                this.transform.Find("description").gameObject.GetComponent<UILabel>().text
                );
        }
        else
        {
            DesCard._instance.NotShowCard();
        }
    }
    public void OnClick(){
        
    }

}