using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unwise : Buff {
	void Awake()
	{
		base.Awake();
		this.setId(3);
		this.setDescription("Decrease x intelligence");
	}
	public override void enable(){
		this._host.increaseIntelligence(-1);
	}
	public override void disable(){
		this._host.increaseIntelligence(1);
	}
}
