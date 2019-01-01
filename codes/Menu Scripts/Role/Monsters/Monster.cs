using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : Role {
	public static Monster _instance;
	public static int Normal = 0;
	public static int Advanced = 1;
	public static int Boss = 2;
	public static string[] normalMonsters = {"Zombie","Slime","Goblin","Snake","Dryad"};
	public static string[] advancedMonsters = {"Witch","Wizard","Robber","Hybrid"};
	public static string[] bossMonsters = {"Ajattara"};
	private Action[] _actions;
	protected double _attackChance;
	protected int[] _damageRange;
	protected double _shieldChance;
	protected int[] _shieldRange;
	protected int[] _coinsDropRange;
	protected int _maxActions;
    protected Action[] actions;
	private int _type;

	protected void Awake(){
		this.hpLabel = this.transform.Find("hp").GetComponent<UILabel>();
		this.shieldLabel = this.transform.Find("shield").GetComponent<UILabel>();
	}

	public static void initNewMonster(int type){
		var monster = System.Reflection.Assembly.Load("Assembly-CSharp").GetType((string)getNewMonster(type));;
		GameObject monsterObject = Global.battleControler.monsterObject;
		DestroyImmediate(monsterObject.GetComponent<Monster>());
		monsterObject.AddComponent(monster);
		BattleControler.monster = monsterObject.GetComponent<Monster>();
		UISprite monsterImg =monsterObject.transform.Find("appearance").transform.Find("monsterImg").GetComponent<UISprite>();
		monsterImg.spriteName=monster.ToString();
		
	}
	
	private static string getNewMonster(int type){
		string[] monsters=null;
		switch(type){
			case 0:
				monsters = normalMonsters;
			break;
			case 1:
				monsters = advancedMonsters;
			break;
			case 2:
				monsters = bossMonsters;
			break;
			default:
			break;
		}
		int r = Random.Range(0,monsters.Length);

		return monsters[r];
	}

    public void doActions(){
		for (int i =0;i<_actions.Length;i++){
			_actions[i].behave();
			Global.battleControler.intentions[i].gameObject.GetComponent<TweenAlpha>().PlayReverse();
		}
		Global.battleControler.changeTurn();
	}

	public void getNextActions(){
		double r = Random.value*_maxActions+1;
		_actions = new Action[(int)r];
		for(int i = 0;i<(int)r;i++){
			_actions[i] = getNewAction();
			Global.battleControler.intentions[i].spriteName = _actions[i].GetType().ToString();
			Global.battleControler.intentions[i].gameObject.GetComponent<TweenAlpha>().PlayForward();
		}
	}

	private Action getNewAction(){
		double r = Random.value;
		
		if(r<=_attackChance){
			int r1 = Random.Range(_damageRange[0],_damageRange[1]);
			return new AttackAction(r1);
		}else if(r <=_attackChance+_shieldChance){
			int r1 = Random.Range(_shieldRange[0],_shieldRange[1]);
			return new ShieldAction(r1);
		}else{
			int buffId = Random.Range(0,7);
			int level = Random.Range(1,3);
			return new SkillAction(buffId,level);
		}
	}
	public void attackPlayer(int damage){
		BattleControler.player.receiveDamage(damage);
	}

	public void setType(int type){
		this._type = type;
	}
}
