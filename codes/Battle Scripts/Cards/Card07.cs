using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card07 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 7, 1);
        
        this.setName("Drink chicken soup");
        this.setDescription("Get 7 chicken soup and consume this hand");

    }

    public override void play()
    {

        //attackMonster();
        shieldPlayer();

        //消耗卡牌
        CardController.instance.consumeCard(this.gameObject);
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Skill, 0, 9, 1);

        this.setName("Drink chicken soup +1");
        this.setDescription("Get 9 chicken soup and consume this hand");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
