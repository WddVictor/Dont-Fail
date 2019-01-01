using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card02 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 8, 0, 2);
    }

    public override void play()
    {
        attackMonster();
        BattleControler.monster.addBuff(0, 2);
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}