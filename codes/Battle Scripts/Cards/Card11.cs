using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card11 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 0, 0);

        this.setName("Bathing and singing");
        this.setDescription("Draw a card. Consumption");

    }

    public override void play()
    {

        //attackMonster();
        //shieldPlayer();


        //抽一张牌
        CardController.instance.GetCard();
        


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
