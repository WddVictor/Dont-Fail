using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card18 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 12, 0, 2);
    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();


        //给予2层困倦
        BattleControler.monster.addBuffLevel(0, 1);


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
