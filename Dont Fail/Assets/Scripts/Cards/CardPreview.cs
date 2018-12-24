using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPreview : Card {

	void Awake()
	{
		base.Awake();
		base.init(Card.Skill,0,5,1);
		this.setName("Preview");
	}


	public override void play(){
		shieldPlayer();
	}
	
	public override void update(){
		if(this._updated){
			return;
		}
		//完成该方法的升级
		this.setCost(0);

		this._updated = true;
	}

	public override void consume(){
		BattleControler.player.increaseUsableMp(2);
	}
}
