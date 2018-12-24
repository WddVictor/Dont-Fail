using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrepareTools : Card {

	void Awake()
	{
		base.Awake();
		base.init(Card.Skill,0,0,1);
		this.setName("Prepare tools");
	}
	
	public override void play(){
		
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
		this.consumed = true;
	}
}
