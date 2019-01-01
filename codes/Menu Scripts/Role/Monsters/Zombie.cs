using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Monster {

	void Awake() 
	{
		base.Awake();
		this._attackChance = 0.8;
		this._shieldChance = 0.1;
		this._damageRange = new int[2] {4,7};
		this._shieldRange = new int[2] {5,15};
		this._coinsDropRange = new int[2] {24,30};
		this._totalHp = 29;
		this._maxActions = 2;
		this.setType(Normal);
	}
	
}
