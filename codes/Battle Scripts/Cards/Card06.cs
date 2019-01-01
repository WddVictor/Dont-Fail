using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card06 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 5, 0, 1);

        this.setName("One heart and two");
        this.setDescription("Reduce the difficulty of 5 points twice");

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
        base.init(Card.Attack, 7, 0, 1);

        this.setName("One heart and two +1");
        this.setDescription("Reduce the difficulty of 7 points twice");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
