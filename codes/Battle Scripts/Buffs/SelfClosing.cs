using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfClosing : Buff {
	void Awake()
	{
		base.Awake();
		this.setId(0);
		this.setDescription("Receive 150% damages");
	}

	public override void enable(){}
	public override void disable(){}
}
