using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card11 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 0, 0);
    }

    public override void play()
    {

        //attackMonster();
        //shieldPlayer();


        //抽一张牌
        CardController.instance.GetCard();

        //将手牌中的一张牌放到你的抽牌堆顶部


        //消耗
        this.consume();
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
