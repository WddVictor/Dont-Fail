using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitAdvancedBattle : MonoBehaviour {
	public void init(){
		Global.battleControler.initBattle(Monster.Advanced);
	}
}
