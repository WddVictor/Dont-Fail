using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyDrink : Drink {
	void Awake()
	{
		this.setId(0);
		base.init();
	}
	public override void enable(){
		BattleControler.player.increaseUsableMp(2);
		this.isUsed = true;
	}
}
