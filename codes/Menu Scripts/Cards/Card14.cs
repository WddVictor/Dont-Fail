using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card14 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 12, 0, 1);
    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();


        //将一张疲惫放入你的抽牌堆中


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
