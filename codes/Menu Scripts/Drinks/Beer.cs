using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : Drink {
	void Awake()
	{
		this.setId(3);
		base.init();
	}
	public override void enable(){
		BattleControler.player.receiveShield(12);
		this.isUsed = true;
	}
}
