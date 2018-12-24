using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkControler : MonoBehaviour {
    
    public GameObject[] drinks;

    public void obtainDrink(){
        string drinkName="Cola";
        var type = System.Type.GetType(drinkName);
        if(type==null){
            return;
        }

        foreach (GameObject drinkObject in drinks)
        {   
            if(drinkObject.GetComponent<Drink>().isUsed){

                Destroy(drinkObject.GetComponent<Drink>());
                drinkObject.AddComponent(type);
                drinkObject.GetComponent<Drink>().init();
                drinkObject.SetActive(true);
                break;
            }
        }

    }
}
