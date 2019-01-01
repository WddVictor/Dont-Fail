using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAction : Action {
	private int _shield;
	public ShieldAction(int shield){
		setShield(shield);
		this._type = Action.ShieldType;
	}
	
	public void setShield(int shield){
		if(shield>=0){
			this._shield = shield;
		}else{
			this._shield = 0;
		}
	}

	public override void behave(){
		BattleControler.monster.receiveShield(getActuralShield());
	}

	private int getActuralShield(){
		int actural_shield = BattleControler.monster.getIntelligence()+_shield;
		return actural_shield;
	}

}
