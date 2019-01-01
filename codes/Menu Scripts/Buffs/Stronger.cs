using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stronger : Buff {
	
	new void Awake()
	{
		base.Awake();
		this.setId(5);
		this.setDescription("Increase x strengths");
	}

	public override void enable(){
		this._host.increaseStrength(1);
	}
	public override void disable(){
		this._host.increaseStrength(-1);
	}
}
