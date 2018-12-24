using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMutualInjury : Card {

	void Awake()
	{
		base.Awake();
		base.init(Card.Attack,18,0,4);
		this.setName("Mutual Injury");
	}

	void Update()
	{	
		this.setCost(this.getOriginCost()-DataPool.playerGetDamageTimes);
	}

	public override void play(){
		attackMonster();
	}
	
	public override void update(){
		if(this._updated){
			return;
		}
		//完成该方法的升级


		this._updated = true;
	}

	public override void consume(){
		this.consumed = true;
	}
}
