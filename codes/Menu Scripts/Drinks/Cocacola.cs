using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocacola : Drink {
	void Awake()
	{
		this.setId(6);
		base.init();
	}
	public override void enable(){
		BattleControler.player.receiveStrength(2);
		this.isUsed = true;
	}
}
