using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajattara : Monster {

	void Awake() 
	{	
		base.Awake();
		this._attackChance = 0.7;
		this._shieldChance = 0.2;
		this._damageRange = new int[2] {12,17};
		this._shieldRange = new int[2] {5,12};
		this._coinsDropRange = new int[2] {60,90};
		this._totalHp = 120;
		this._maxActions = 2;
		setType(Boss);
	}
	
}
