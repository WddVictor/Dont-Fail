using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour {
	//卡牌的不同种类
	public static int Attack = 0;
	public static int Skill = 1;

	public static int Ability = 2;
	
	public static int Condition = 3;

	public static int Curse = 4;

	

	//牌面伤害	
	protected int _id;
	protected int _type;
	private string _name;
	protected int _damage;
	protected int _shield;
	private int _cost;
	private int _originCost;
	protected string _description;
	public bool consumed;

	protected bool _updated;
	public UILabel damageLabel;
	public UILabel shieldLabel;
	private UILabel nameLabel;
	private UILabel costLabel;
	private UILabel descriptionLabel;

	protected void Awake()
	{
		this.nameLabel = this.transform.Find("name").GetComponent<UILabel>();
		this.costLabel = this.transform.Find("cost").GetComponent<UILabel>();
		this.descriptionLabel = this.transform.Find("description").GetComponent<UILabel>();
		_updated = false;
		consumed = false;
	}
	public void OnClick()
    {

        CardController.instance.UseCard(this.gameObject);
    }


	public void OnHover(bool isHover)
    {	
		if(DesCard._instance !=null && BattleControler.start){
			if (isHover)
			{
				DesCard._instance.ShowCard(
					this.transform.Find("cost").gameObject.GetComponent<UILabel>().text,
					this.transform.Find("name").gameObject.GetComponent<UILabel>().text,
					this.transform.Find("description").gameObject.GetComponent<UILabel>().text
					);
			}
			else
			{
				DesCard._instance.NotShowCard();
			}
		}
    }

	public void init(int type = 0,int damage=0,int shield = 0,int cost = 0){
		setOriginCost(cost);
		setCost(cost);
		setDamage(damage);
		setShield(shield);
		this._type = type;
	}

	public void setCost(int cost){
		if(cost <0){
			this._cost = 0;
		}else
		{
			this._cost = cost;
		}
		showCost();
	}
	
	public int getCost(){
		return this._cost;
	}

	public void setOriginCost(int cost){
		this._originCost = cost;
	}

	public int getOriginCost(){
		return this._originCost;
	}

	public void setDamage(int damage){
		this._damage = damage;
		//还需要加入改变卡牌的攻击显示的代码



	}

	public int getDamage(){
		return this._damage;
	}

	public void setShield(int shield){
		this._shield = shield;
		//还需要加入改变卡牌的护盾显示的代码


		
	}

	public int getShield(){
		return this._shield;
	}

	

	public void setName(string name){

		this._name = name;
		showName();
	}

	public void setDescription(string description){
		this._description = description;
		showDescription();
	}
	public void showDamage(){
		if(damageLabel){
			damageLabel.text = _damage+"";
		}
	}

	public void showCost(){
		if(costLabel){
			costLabel.text = _cost+"";
		}
	}

	public void showShield(){
		if(shieldLabel){
			shieldLabel.text = _shield+"";
		}
	}

	public void showName(){
		if(nameLabel){
			nameLabel.text = this._name;
		}
	}

	public void showDescription(){
		if(descriptionLabel){
			descriptionLabel.text = _description;
		}
	}

	//给玩家加护盾
	public void shieldPlayer(){
		BattleControler.player.receiveShield(getActuralShield());
	}


	//造成伤害，可被护盾抵消
	public void attackMonster(){
		BattleControler.monster.receiveDamage(getActuralDamage());
	}

	//真实伤害，无视护盾
	public void tureDamageMonster(){
		BattleControler.monster.increaseUsableHp(-getActuralDamage());
	}

	//获得由力量加成或者buff加成后的伤害
	private int getActuralDamage(){
		
		int actural_damage = BattleControler.player.getStrength()+_damage;
		return actural_damage>0?actural_damage:0;
	}

	//获得由智力加成或者buff加成后的伤害
	private int getActuralShield(){
		int actural_shield = BattleControler.player.getIntelligence()+_shield;
		return actural_shield>0?actural_shield:0;
	}
	//出牌的逻辑应当在每张牌的play中写好，默认的敌人是monster
	public abstract void play();

	//返回当前卡牌的消耗能量是否小于可用能量 
	//若为真则更新界面的能量显示
	public bool refreshMp(){
		if(this._cost<=BattleControler.player.getUsableMp()){
			BattleControler.player.increaseUsableMp(-this._cost);
			Debug.Log(this.GetType());
			return true;
		}else{
			return false;
		}
	}

	public abstract void update();

	public virtual void consume(){
		this.consumed = true;

	}

}
