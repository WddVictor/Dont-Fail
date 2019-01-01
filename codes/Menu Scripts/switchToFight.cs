using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchToFight : MonoBehaviour {

	// Use this for initialization
	void Start () {
        TweenScale scale = GetComponent<TweenScale>();
        EventDelegate.Add(scale.onFinished, OnFinished);
    }
	
    void OnFinished()
    {
        GameObject.Find("map_interface").SetActive(false);
        GameObject.Find("legend_interface").SetActive(false);
        if(TweenScale.current.name == "barrier")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("battle_interface").gameObject;
            battle.SetActive(true);
            GameObject battleControl = root.transform.Find("battle_interface/bg/BattleControler").gameObject;
            battleControl.GetComponent<BattleControler>().initBattle(Monster.Normal);
        }else if (TweenScale.current.name == "big_barrier")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("battle_interface").gameObject;
            battle.SetActive(true);
            GameObject battleControl = root.transform.Find("battle_interface/bg/BattleControler").gameObject;
            battleControl.GetComponent<BattleControler>().initBattle(Monster.Advanced);
        }
        else if (TweenScale.current.name == "shop")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("shop_interface").gameObject;
            battle.SetActive(true);
        }
        else if (TweenScale.current.name == "unknown")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("unknown_interface").gameObject;
            battle.SetActive(true);
        }
        else if (TweenScale.current.name == "treasure")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("treasure_interface").gameObject;
            battle.SetActive(true);
        }
        else if (TweenScale.current.name == "rest")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("rest_interface").gameObject;
            battle.SetActive(true);
        }else if(TweenScale.current.name == "boss")
        {
            GameObject root = GameObject.Find("UI Root");
            GameObject battle = root.transform.Find("battle_interface").gameObject;
            battle.SetActive(true);
            GameObject battleControl = root.transform.Find("battle_interface/bg/BattleControler").gameObject;
            battleControl.GetComponent<BattleControler>().initBattle(Monster.Boss);
        }
    }
}
