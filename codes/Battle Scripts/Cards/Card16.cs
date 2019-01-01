using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card16 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 8, 1);

        this.setName("Canteen eating");
        this.setDescription("Get 8 chicken soup and draw a card");

    }

    public override void play()
    {
        //attackMonster();
        //shieldPlayer();
        CardController.instance.GetCard();
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Skill, 0, 10, 1);

        this.setName("Canteen eating +1");
        this.setDescription("Get 10 chicken soup and draw a card");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}