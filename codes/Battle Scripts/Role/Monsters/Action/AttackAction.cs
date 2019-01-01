using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : Action {
	private int _damage;
	public AttackAction(int damage){
		setDamage(damage);
		this._type = Action.AttackType;
	}
	public void setDamage(int damage){
		if(damage>=0){
			this._damage = damage;
		}else{
			this._damage = 0;
		}
	}

	public override void behave(){
		BattleControler.monster.attackPlayer(getActuralDamage());
	}

	private int getActuralDamage(){
		int actural_damage = BattleControler.monster.getStrength()+_damage;
		return actural_damage;
	}

}
