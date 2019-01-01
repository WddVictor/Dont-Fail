using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card17 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 14, 0, 2);
    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();


        //降低14点难度,学力在该牌上发挥3倍效果


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
