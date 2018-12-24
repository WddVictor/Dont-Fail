using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : Role {
    public abstract void attackPlayer(int damage);
    protected ArrayList actions = new ArrayList();
    public void doActions(){
		if(this.actions.Count!=0){ 
			foreach(Action i in this.actions){
				i.behave();
			}
            this.actions.Clear();
            this.actions.Add(new AttackAction(1));
            Global.battleControler.changeTurn();
		}else{
			Debug.Log("no action this turn");
		}
	}
}
