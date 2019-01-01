using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action{
	public static int AttackType = 0;
	public static int ShieldType = 1;
	public static int SkillType = 2;
	protected int _type;
	public abstract void behave();
	public int getType(){
		return this._type;
	}

}
 