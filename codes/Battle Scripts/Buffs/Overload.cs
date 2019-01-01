using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overload : Buff {
	void Awake()
	{
		base.Awake(); 
		this.setId(4);
		this.setDescription("Decrease x strengths in the end of this turn");
	}

	void Update()
	{	
		if(getLevel()!=0&&BattleControler.turnState==BattleControler.AfterState){
			this._host.increaseIntelligence(-getLevel());
			this.setLevel(0);
		}
	}

	public override void enable(){}
	public override void disable(){
		
	}
}
