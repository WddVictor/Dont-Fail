using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card05 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 9, 0, 1);
    }

    public override void play()
    {

        attackMonster();
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
