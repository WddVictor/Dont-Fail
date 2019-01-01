using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Drink : MonoBehaviour {
    public static string[] drinksLibrary={"EnergyDrink","Poison","Water","Beer","ChiliSauce","Mustard","Cocacola","Pepsi"};

	protected int _id;
	protected string _name;
	protected string _description;
	private int originalMoneyCost;
	public bool isUsed;
	//需要填充

	public void init(){
		this.isUsed = false;
		this.setName(this.GetType().ToString());
		this.GetComponent<UISprite>().spriteName = this._name;
		this.GetComponent<UIButton>().normalSprite = this._name;
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
