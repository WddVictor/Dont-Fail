using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleepy : Buff {
	void Awake()
	{
		base.Awake();
		this.setId(1);
		this.setDescription("Receive 75% shield");
	}

	public override void enable(){}
	public override void disable(){}
}
