using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Role : MonoBehaviour {

	public int _usableHp;
	public int _totalHp;
	public int _usableShield;
	public int strength=0;
	public int intelligence=0;

	public GameObject enemyObject;
	private Role enemy;
	public UILabel hpLabel;
	public UILabel shieldLabel;

	private ArrayList buffs;

	protected void Start()
	{	
		if(this.enemyObject){
			this.enemy = this.enemyObject.GetComponent<Role>();
		}
		showHp();
		showShield();
		buffs = new ArrayList();
	}

	//这个方法需要后续完成 默认初始加1层
	public void addBuff(int buffId=0,int levelOffset=1){

		//注意这个地方的new Buff需要add GameObject 到界面

	}

	
	public void addBuffLevel(int buffId=0,int levelOffset=1){
		if(levelOffset<=0){
			return;
		}
		bool hasBuff = false;
		foreach (Buff buff in buffs)
		{
			if(buff.getId()==buffId){
				buff.setLevel(buff.getLevel()+levelOffset);
				hasBuff = true;
				break;
			}
		}
		if(!hasBuff){
			addBuff(buffId,levelOffset);
		}
	}

	public void removeBuff(int buffId=0){

	}

	public void removeBuffLevel(int buffId=0,int levelOffset=1){
		foreach (Buff buff in buffs)
		{
			if(buff.getId()==buffId){
				int newLevel = buff.getLevel()-levelOffset;
				buff.setLevel(newLevel);
				if(newLevel<=0){
					buffs.Remove(buff);
				}
				break;
			}
		}
	}

	bool isDead(){
		return this._usableHp<=0;
	}
	public void init(int totalHp){
		_totalHp = totalHp;
		_usableHp = _totalHp;
		_usableShield = 0;
	}


	public void recieveDamage(int offset){
		int remind = this._usableShield+offset;
		increaseShield(offset);
		if(remind<0){
			increaseUsableHp(remind);
		}
		
	}

	public abstract void recieveShield(int offset);

	public void increaseUsableHp(int offset){
		if(this.GetType()==typeof(Player)){
			DataPool.playerGetDamageTimes+=1;
		}else if(this.GetType()==typeof(Monster)){
			DataPool.monsterGetDamageTimes+=1;
		}
		_usableHp += offset;
		if (_usableHp<0){
			_usableHp =0;
		}
		showHp();
		if(this.isDead()){
			Global.battleControler.afterBattle();
		}
	}
	public void increaseTotalHp(int offset){
		_totalHp+=offset;
		if (_totalHp<0){
			_totalHp = 0;
		}
		if(_totalHp<=_usableHp){
			_usableHp = _totalHp;
		}else{
			if(offset>0){
				_usableHp+=offset;
			}
		}
		showHp();
	}	

	public void increaseShield(int offset){
		_usableShield += offset;
		if (_usableShield<0){
			
			_usableShield =0;
		}
		showShield();
	}



	public void showHp(){
		if(this.hpLabel){
			this.hpLabel.text= this._usableHp+"/"+this._totalHp;
		}
	}

	public void showShield(){
		if(this.shieldLabel){
			this.shieldLabel.text= this._usableShield+"";
		}
	}

	public int getShield(){
		return this._usableShield;
	}
	
}
