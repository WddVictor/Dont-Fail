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

	public GameObject playerObject;
	public GameObject monsterObject;
	public GameObject endButtonObject;
	public GameObject turnFlag;
	public GameObject fightFlag;

	public static Player player=null; 
	public static Monster monster=null;

	private EndButtonControler endButtonControler;

	void Awake()
	{	
		Global.battleControler = this;
		player = playerObject.GetComponent<Player>();
		monster = monsterObject.GetComponent<Monster>();
		endButtonControler = endButtonObject.GetComponent<EndButtonControler>();
		initBattle();
	}

	public void initBattle(){
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
		}else{
			endButtonControler.enableButton();
		}
		turnState = DuringState;
	}
	void duringTurn(){
		if(thisTurn == Global.monsterTurn){
			monster.doActions();
		}
		turnState = BeforeState;
	}


	void beforeBattle(){
		BattleControler.thisTurn = Global.playerTurn;
		BattleControler.turnState = 0;
		BattleControler.battleState = 0;
		this.fightFlag.GetComponent<TweenAlpha>().PlayForward();
	}

	public void afterBattle(){
		player.increaseShield(-player.getShield());
	} 
	

}
