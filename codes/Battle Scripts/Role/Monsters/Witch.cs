using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : Monster {

	void Awake() 
	{
		base.Awake();

		this._attackChance = 0.2;
		this._shieldChance = 0.4;
		this._damageRange = new int[2] {2,3};
		this._shieldRange = new int[2] {4,6};
		this._coinsDropRange = new int[2] {45,50};
		this._totalHp = 50;
		this._maxActions = 4;
		setType(Advanced);

	}
	
}
