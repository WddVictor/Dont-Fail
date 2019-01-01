using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card20 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 4, 0, 1);


        this.setName("View directory");
        this.setDescription("Reduce all difficulty by 4 points and give 1 layer of autism");

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
        base.init(Card.Attack, 7, 0, 1);


        this.setName("View directory +1");
        this.setDescription("Reduce all difficulty by 7 points and give 1 layer of autism");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}