using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card01 : Card {

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 6, 0, 1);
        this.setName("Learn");
        this.setDescription("Reduce the difficulty of 6 points");
    }

    public override void play()
    {
        attackMonster();
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 9, 0, 1);
        this.setName("Learn +1");
        this.setDescription("Reduce the difficulty of 9 points");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
