using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card09 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 6, 0, 2);
    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();
        
        //每有一张攻击牌,降低的难度值+2

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
