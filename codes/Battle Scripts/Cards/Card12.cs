using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card12 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 5, 1);

        this.setName("Upper class");
        this.setDescription("Get 5 chicken soup, upgrade one card in the hand");

    }

    public override void play()
    {

        //attackMonster();
        shieldPlayer();


        //在本场战斗中升级手牌中的一张牌
        update();

    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Skill, 0, 8, 1);

        this.setName("Upper class +1");
        this.setDescription("Get 8 chicken soup, upgrade one card in the hand");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
