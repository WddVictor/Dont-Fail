using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card08 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 9, 0, 1);
    }

    public override void play()
    {

        attackMonster();

        //将弃牌堆里的一张牌放在抽牌堆顶部

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
