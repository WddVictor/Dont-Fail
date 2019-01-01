using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card02 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 8, 0, 2);
        this.setName("study hard");
        this.setDescription("Reduce the difficulty of 8 points and give 2 layers of autism");
    }

    public override void play()
    {
        attackMonster();
        BattleControler.monster.addBuff(0, 2);
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 10, 0, 2);
        this.setName("study hard +1");
        this.setDescription("Reduce the difficulty of 10 points and give 2 layers of autism");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}