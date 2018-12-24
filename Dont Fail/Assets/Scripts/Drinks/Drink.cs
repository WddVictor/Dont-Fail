using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Drink : MonoBehaviour {

	protected int _id;
	protected string _name;
	protected string _description;
	public bool isUsed;
	//需要填充
	protected void Awake()
	{
		init();
	}
	public void init(){
		this.isUsed = false;
	}

	public void showName(){

	}

	public void setName(string name){
		this._name = name;
		showName();
	}

	public string getName(){
		return this._name;
	}

	public void setId(int id){
		this._id = id;
	}

	public abstract void enable();
}
