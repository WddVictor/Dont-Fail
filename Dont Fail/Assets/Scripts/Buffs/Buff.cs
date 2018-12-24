using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : MonoBehaviour {

	public GameObject hostObject;
	public GameObject enemyObject;
	//挂载该buff的角色
	protected int _id;
	protected Role _host;	
	//该角色的敌人
	protected Role _enemy;
	protected int _level;

	void Awake(){
		this._host = hostObject.GetComponent<Role>();
		this._enemy = enemyObject.GetComponent<Role>();
	}
	//buff生效
	public abstract void enable();

	//buff失效
	public abstract void disable();

	public void setLevel(int level){
		if(level<=0){
			this._level = 0;
			this.disable();
		}else{
			this._level = level;
		}
	}

	public int getLevel(){
		return this._level;
	}

	public int getId(){
		return this._id;
	}
}
