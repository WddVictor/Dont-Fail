using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_map_in_battle : MonoBehaviour {

    public void Show()
    {
        if (this.gameObject.activeInHierarchy)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }  
    }

}
