using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkButton : MonoBehaviour {

    public void enable(){
        this.GetComponent<Drink>().enable();
        this.gameObject.SetActive(false);
    }
    

}
