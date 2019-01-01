using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hybrid : Monster {

	void Awake() 
	{
		base.Awake();

		this._attackChance = 0.4;
		this._shieldChance = 0.3;
		this._damageRange = new int[2] {6,8};
		this._shieldRange = new int[2] {5,6};
		this._coinsDropRange = new int[2] {40,55};
		this._totalHp = 60;
		this._maxActions = 3;
		setType(Advanced);
	}
	
}
