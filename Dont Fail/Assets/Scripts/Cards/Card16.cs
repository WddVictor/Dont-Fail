using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card16 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 8, 1);
    }

    public override void play()
    {
        //attackMonster();
        shieldPlayer();

        CardController.instance.GetCard();
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