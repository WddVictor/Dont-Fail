using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card19 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 5, 5, 1);

        this.setName("Listening to class");
        this.setDescription("Get 5 chicken soup and reduce 5 difficulty");

    }

    public override void play()
    {
        attackMonster();
        shieldPlayer();


    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 7,7, 1);

        this.setName("Listening to class +1");
        this.setDescription("Get 7 chicken soup and reduce 7 difficulty");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}