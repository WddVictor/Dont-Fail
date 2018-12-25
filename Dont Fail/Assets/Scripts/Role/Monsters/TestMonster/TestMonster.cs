using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonster : Monster {

	void Awake(){
		this.actions.Add(new AttackAction(10));
	}

	public override void attackPlayer(int damage){
		BattleControler.player.receiveDamage(damage);
	}
}
