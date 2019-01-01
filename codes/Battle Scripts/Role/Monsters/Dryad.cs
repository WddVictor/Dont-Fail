using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dryad : Monster {

	void Awake() 
	{
		base.Awake();
		this._attackChance = 0.4;
		this._shieldChance = 0.4;
		this._damageRange = new int[2] {3,6};
		this._shieldRange = new int[2] {3,6};
		this._coinsDropRange = new int[2] {30,40};
		this._totalHp = 30;
		this._maxActions = 3;
		setType(Normal);
	}
	
}
