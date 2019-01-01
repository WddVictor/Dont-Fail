using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChiliSauce : Drink {
	void Awake()
	{
		this.setId(4);
		base.init();
	}
	public override void enable(){
		BattleControler.monster.addBuff(4,2);
		this.isUsed = true;
	}
}
