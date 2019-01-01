using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster {

	void Awake() 
	{
		base.Awake();
		this._attackChance = 0.6;
		this._shieldChance = 0.3;
		this._damageRange = new int[2] {4,6};
		this._shieldRange = new int[2] {1,3};
		this._coinsDropRange = new int[2] {20,24};
		this._totalHp = 24;
		this._maxActions = 3;
		setType(Normal);
	}
	
}
