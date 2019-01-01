using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card10 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 6, 0, 0);
    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();

        
        //在弃牌堆放入一张此牌的复制品
        
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
