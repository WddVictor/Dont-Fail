using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButtonControler : MonoBehaviour {

	// Use this for initialization
	private UIButton endButton;
	public GameObject endButtonObject;
	
	void Awake()
	{
		this.endButton = endButtonObject.GetComponent<UIButton>();
	}

	public void enableButton(){
		endButton.isEnabled = true;
	}

	public void disableButton(){
		endButton.isEnabled = false;
	}

	public void isClicked(){
		if(endButton.isEnabled&&(BattleControler.thisTurn==Global.playerTurn)){
			disableButton();
			CardController.instance.DisAllCards();

			Global.battleControler.changeTurn();
		}else{
			Debug.Log((BattleControler.thisTurn==Global.playerTurn));	

		}
	}
}
