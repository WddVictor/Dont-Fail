using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Drink {
	void Awake()
	{
		this.setId(2);
		base.init();
	}
	public override void enable(){
		BattleControler.player.increaseUsableHp(8);
		this.isUsed = true;
	}
}
