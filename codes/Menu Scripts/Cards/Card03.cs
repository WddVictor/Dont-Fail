using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card03 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 5, 1);
    }

    public override void play()
    {
 //       attackMonster();
        shieldPlayer();
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
