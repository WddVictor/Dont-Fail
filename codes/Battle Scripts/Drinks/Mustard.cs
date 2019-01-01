using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mustard : Drink {
	void Awake()
	{
		this.setId(5);
		base.init();
	}
	public override void enable(){
		for(int i =0;i<3;i++){
			CardController.instance.GetCard();
		}
		this.isUsed = true;
	}
}
