using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card06 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 5, 0, 1);
    }

    public override void play()
    {

        attackMonster();
        attackMonster();
        
        //shieldPlayer();
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
