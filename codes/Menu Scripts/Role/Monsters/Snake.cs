using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Monster {

	void Awake() 
	{
		base.Awake();
		this._attackChance = 0.7;
		this._shieldChance = 0.3;
		this._damageRange = new int[2] {4,6};
		this._shieldRange = new int[2] {2,6};
		this._coinsDropRange = new int[2] {25,30};
		this._totalHp = 27;
		this._maxActions = 3;
		setType(Normal);

	}
	
}
