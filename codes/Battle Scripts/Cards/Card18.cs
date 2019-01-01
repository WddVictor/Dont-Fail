using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card18 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 12, 0, 2);
              
        this.setName("Turn off the lights");
        this.setDescription("Reduce the difficulty of 12 points and give 2 layers of sleepiness");

    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();


        //给予2层困倦
        BattleControler.monster.addBuff(4, 2);
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 15, 0, 2);

        this.setName("Turn off the lights +1");
        this.setDescription("Reduce the difficulty of 15 points and give 2 layers of sleepiness");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
