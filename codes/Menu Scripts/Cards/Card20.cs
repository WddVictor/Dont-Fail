using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card20 : Card
{

    new void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 4, 0, 1);
    }

    public override void play()
    {
        attackMonster();

        //让所有难题降低4点难度,给予1层自闭
        BattleControler.monster.addBuff(0, 1);

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