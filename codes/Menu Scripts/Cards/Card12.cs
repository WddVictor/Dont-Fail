using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card12 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 5, 1);
    }

    public override void play()
    {

        //attackMonster();
        shieldPlayer();


        //在本场战斗中升级手牌中的一张牌
        update();

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
