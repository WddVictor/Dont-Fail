using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card15 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 0, 0, 1);
    }

    public override void play()
    {
        //attackMonster();
        //shieldPlayer();

        //打出抽牌堆顶部的牌,将其消耗


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