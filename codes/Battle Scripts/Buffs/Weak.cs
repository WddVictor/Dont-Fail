using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weak : Buff {
	void Awake()
	{
		base.Awake();
		this.setId(2);
		this.setDescription("Decrease x strengths");
	}

	public override void enable(){
	}
	public override void disable(){
	}
}
