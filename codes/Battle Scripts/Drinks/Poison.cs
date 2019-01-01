using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Drink {
	void Awake()
	{
		this.setId(1);
		base.init();
	}
	public override void enable(){
		BattleControler.monster.receiveDamage(10);
		this.isUsed = true;
	}
}
