using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : MonoBehaviour {

	public GameObject hostObject;
	private UILabel _levelLabel;
	private UILabel _descriptionLabel;
	//挂载该buff的角色
	protected int _id;
	private string _description;
	protected Role _host;	
	//该角色的敌人
	protected int _level =0;
	
	protected void Awake(){
		this._host = hostObject.GetComponent<Role>();
		this._levelLabel = this.transform.Find("level").GetComponent<UILabel>();
		this._descriptionLabel = this.transform.Find("description").GetComponent<UILabel>();
		this.GetComponent<UISprite>().spriteName = this.GetType().ToString();

		this.init();
	}	

	public void init(){
		this.setLevel(0);
	}
	
	public abstract void enable();

	//buff失效
	public abstract void disable();

	public void setLevel(int level){
		if(level<=0){
			this._level = 0;
		}else{
			this._level = level;
		}
		showLevel();
	}

	public void setDescription(string description){
		this._description = description;
		showDescripiton();
	}
	public int getLevel(){
		return this._level;
	}

	public int getId(){
		return this._id;
	}
	public void setId(int id){
		this._id = id;
	}

	private void showLevel(){
		if(this._level<=0){
			this.gameObject.SetActive(false);
		}else{
			this.gameObject.SetActive(true);
		}
		this._levelLabel.text = this._level+"";

	}

	private void showDescripiton(){
		this._descriptionLabel.text = this._description;
	}
	
}
