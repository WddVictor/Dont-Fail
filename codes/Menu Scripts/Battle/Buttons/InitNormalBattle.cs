using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitNormalBattle : MonoBehaviour {
	public void init(){
		Global.battleControler.initBattle(Monster.Normal);
	}
}
