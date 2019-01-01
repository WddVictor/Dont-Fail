using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BattleControler : MonoBehaviour {

	// Use this for initialization

	public static int BeforeState = 0;
	public static int DuringState = 1;
	public static int AfterState = 2;
	public static bool thisTurn;
	public static int turnState;
	public static int battleState;
	public static bool start = false;
	public GameObject playerObject;
	public GameObject monsterObject;
	public GameObject endButtonObject;
	public GameObject turnFlag;
	public GameObject fightFlag;
	public UISprite[] intentions;
	public GameObject[] monsterBuffs;
	public GameObject[] playerBuffs;

	public static Player player=null; 
	public static Monster monster=null;

	private EndButtonControler endButtonControler;

	void Start()
	{	
		Global.battleControler = this;
		player = playerObject.GetComponent<Player>();
		monster = monsterObject.GetComponent<Monster>();
		endButtonControler = endButtonObject.GetComponent<EndButtonControler>();
		initBattle(Monster.Advanced);

	}

	public void initBattle(int monsterType){
		Monster.initNewMonster(monsterType);
		battleState = BeforeState;
		beforeBattle();
		beforeTurn();
		battleState = DuringState;
	}

	public void changeTurn(){
		thisTurn =!thisTurn;
		beforeTurn();
		duringTurn();
	}

	void beforeTurn(){
		if(thisTurn == Global.playerTurn){
			player.initMp();
		
			if(battleState == DuringState){
				turnFlag.GetComponent<TweenAlpha>().PlayForward();
			}

			for(int i = 0;i<player.shuffles;i++){
				CardController.instance.GetCard();
			}
		}else{
			endButtonControler.enableButton();
		}
		turnState = DuringState;
	}
	void duringTurn(){
		if(thisTurn == Global.monsterTurn){
			monster.doActions();
			monster.getNextActions();
		}
		turnState = BeforeState;
	}


	void beforeBattle(){
		thisTurn = Global.playerTurn;
		turnState = 0;
		battleState = 0;
		this.fightFlag.GetComponent<TweenAlpha>().PlayForward();
		start = true;
		monster.getNextActions();
	}

	public void afterBattle(){
		BattleControler.battleState = AfterState;
		start = false;
		
	} 
	

}
