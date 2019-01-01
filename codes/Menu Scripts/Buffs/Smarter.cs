using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smarter : Buff {
	new void Awake()
	{
		base.Awake();
		this.setId(6);
		this.setDescription("Increase x intelligence");
	}

	public override void enable(){
		this._host.increaseIntelligence(1);
	}
	public override void disable(){
		this._host.increaseIntelligence(-1);
	}
}
