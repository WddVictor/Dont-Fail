using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Monster {

	void Awake() 
	{
		base.Awake();

		this._attackChance = 0.3;
		this._shieldChance = 0.3;
		this._damageRange = new int[2] {3,4};
		this._shieldRange = new int[2] {2,5};
		this._coinsDropRange = new int[2] {40,55};
		this._totalHp = 55;
		this._maxActions = 4;
		setType(Advanced);
	}
	
}
