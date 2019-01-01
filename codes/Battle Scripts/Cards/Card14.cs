using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card14 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 12, 0, 1);

        this.setName("Late night review");
        this.setDescription("Reduce the difficulty of 12 points and put a piece of fatigue into your draw");

    }

    public override void play()
    {

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
        base.init(Card.Attack, 12, 0, 1);

        this.setName("Late night review +1");
        this.setDescription("Reduce the difficulty of 12 points and put a piece of fatigue into your draw");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
