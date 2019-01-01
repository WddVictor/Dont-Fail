using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Role : MonoBehaviour {

	public int _usableHp;
	public int _totalHp;
	public int _usableShield;
	private int _strength=0;
	private int _intelligence=0;
	public UILabel hpLabel;
	public UILabel shieldLabel;

	private Buff[] buffs=new Buff[7];
	

	protected void Start()
	{	

		Transform buffsObject = this.transform.Find("buffs").GetComponent<Transform>();
		foreach (Transform child in buffsObject)
		{

			Buff buff = child.GetComponent<Buff>();
			buffs[buff.getId()] = buff;
		}
		init();
	}
	public void init(){
		setUsableHp(_totalHp);
		this.increaseShield(-_usableShield);
		initBuffs();
	}

	public void initBuffs(){
		
		for (int i =0;i<buffs.Length;i++)
		{	
			Buff buff = buffs[i];
			buff.init();			
		}
	} 
	//判断角色上是否挂载了buff 
	public bool hasBuff(int buffId){
		return buffs[buffId].getLevel()<=0?false:true;
	}

	public void addBuff(int buffId=2,int levelOffset=1){
		if(levelOffset<=0){
			return;
		}
		Buff buff = buffs[buffId];
		buff.setLevel(buff.getLevel()+levelOffset);
		for(int i = 0;i<levelOffset;i++){
			buff.enable();
		}

	}

	public void removeBuff(int buffId=0,int levelOffset=1){
		if(levelOffset<=0){
			return;
		}
		Buff buff = buffs[buffId];
		int newLevel = buff.getLevel()-levelOffset;
		buff.setLevel(newLevel);
		for(int i = 0;i<levelOffset;i++){
			buff.disable();
		}
	}

	bool isDead(){
		return this._usableHp<=0;
	}


	public void receiveStrength(int offset){
		this._strength+=offset;
	}

	public void receiveIntelligence(int offset){
		this._intelligence+=offset;
	}

	public void receiveDamage(int offset){
		if(offset>0){
			offset = this.hasBuff(0)?(int)(offset*1.5):offset;
		}
		int remind = this._usableShield-offset;
		increaseShield(-offset);
		if(remind<0){
			increaseUsableHp(remind);
		}
		
	}

	public void receiveShield(int offset){
		if(offset>0){
			offset = this.hasBuff(1)?(int)(offset*0.75):offset;
		}
		increaseShield(offset);
	}
	
	public void increaseStrength(int offset){
		this._strength+=offset;
	}
	public void increaseIntelligence(int offset){
		this._strength+=offset;
	}

	public void increaseUsableHp(int offset){
		if(offset<0){
			if(this.GetType()==typeof(Player)){
				DataPool.playerGetDamageTimes+=1;
			}else if(this.GetType()==typeof(Monster)){
				DataPool.monsterGetDamageTimes+=1;
			}
		}
		_usableHp += offset;
		if (_usableHp<0){
			_usableHp =0;
		}else if(_usableHp>_totalHp){
			_usableHp = _totalHp;
		}
		showHp();
		if(this.isDead()){
			// if(this.GetType()=typeof(Player)){
			// 	Gloabl.Fail.SetActive(true);
			// }else{
			// 	if(this.GetTypee().getType()==Boss)
			// 	Gloabl.Win
			// }
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
	public int getStrength(){
		return this._strength;
	}
	public void setStrength(int strength){
		this._strength = strength;
	}
	public int getIntelligence(){
		return this._intelligence;
	}
	public void setIntelligence(int intelligence){
		this._intelligence = intelligence;
	}

	public void setUsableHp(int usableHp){
		this._usableHp = usableHp;
		showHp();
	}
	
}
