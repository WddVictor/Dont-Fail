using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card07 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 7, 1);
    }

    public override void play()
    {

        //attackMonster();
        shieldPlayer();

        //消耗一张卡牌

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
