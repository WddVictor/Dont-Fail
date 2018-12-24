using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card21 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 8, 0, 1);
    }

    public override void play()
    {
        attackMonster();


        //让所有难题降低8点难度



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