using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Role {

	public int _usableMp = 3;
	public int _totalMp = 3;

	//显示能量的label
	public UILabel mpLabel;
	
	//自己的牌库
	private Card[] libarary;

	//自己的弃牌(在牌库数组中的地址)
	private int[] abandoned;
	//自己的手牌(同上)
	private int[] hand;
	//摸牌堆(同上)
	private int[] heap;

	//角色初始化
	void Start()
	{	
		base.Start();
		initMp();
		showMp();	
	}
	
	//战斗开始时使可用能量等于总能量
	public void initMp(){
		_usableMp = _totalMp;
		showMp();
	}

	public int getUsableMp(){
		return this._usableMp;
	}
	//增加自己当前能量(可超过总能量限制)
	public void increaseUsableMp(int offset){
		_usableMp += offset;
		if (_usableMp<0){
			_usableMp =0;
		}
		showMp();
	}
	//自己获得护盾时调用
	public override void recieveShield(int offset){
		this.increaseShield(offset);
	}
	//增加自己总能量并显示
	public void increaseTotalMp(int offset){
		_totalMp += offset;
		if (_usableMp<1){
			_usableMp =1;
		}
		showMp();
	}
	//显示自己的总能量到界面
	public void showMp(){
		if(this.mpLabel){
			this.mpLabel.text= _usableMp+"/"+_totalMp;
		}
	}

	//出牌
	public void playCard(Card card){
		card.play();
	}
}
