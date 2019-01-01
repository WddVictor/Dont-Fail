using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBossBattle : MonoBehaviour {
	public void init(){
		Global.battleControler.initBattle(Monster.Boss);
	}
}
