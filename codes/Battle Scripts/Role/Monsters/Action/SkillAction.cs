using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAction : Action {
	private int _buffId;
	private Role _target;
	private int _level;
	public SkillAction(int buffId,int level){
		this._level = level;
		this._buffId = buffId;
		if(buffId>4){
			this._target = BattleControler.monster;
		}else{
			this._target = BattleControler.player;
		}
		this._type = Action.SkillType;
	}
	public override void behave(){
		this._target.addBuff(this._buffId,this._level);
	}
}
