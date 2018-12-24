using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola : Drink {
	void Awake()
	{
		base.Awake();
		this.setId(0);
	}
	public override void enable(){
		BattleControler.player.increaseUsableMp(2);
		this.isUsed = true;
	}
}
