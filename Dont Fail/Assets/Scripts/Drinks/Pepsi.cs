using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepsi : Drink {
	void Awake()
	{
		this.setId(7);
		base.init();
	}
	public override void enable(){
		BattleControler.player.receiveIntelligence(2);
		this.isUsed = true;
	}
}
