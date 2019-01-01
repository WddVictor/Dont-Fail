using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : Monster {

	void Awake() 
	{
		base.Awake();
		this._attackChance = 0.4;
		this._shieldChance = 0.4;
		this._damageRange = new int[2] {2,4};
		this._shieldRange = new int[2] {2,4};
		this._coinsDropRange = new int[2] {12,20};
		this._totalHp = 30;
		this._maxActions = 2;
		setType(Normal);

	}
}
