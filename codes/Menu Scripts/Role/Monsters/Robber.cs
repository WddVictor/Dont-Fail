using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber : Monster {

	void Awake() 
	{
		base.Awake();

		this._attackChance = 0.7;
		this._shieldChance = 0.1;
		this._damageRange = new int[2] {6,7};
		this._shieldRange = new int[2] {4,7};
		this._coinsDropRange = new int[2] {40,120};
		this._totalHp = 55;
		this._maxActions = 3;
		setType(Advanced);

	}
	
}
