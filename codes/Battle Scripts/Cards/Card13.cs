using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card13 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 0, 0);

        this.setName("Bring glasses");
        this.setDescription("Gain 2 semester, lose two points of abilities after the end of your turn");

    }

    public override void play()
    {

        //attackMonster();
        //shieldPlayer();

       
        BattleControler.monster.addBuff(6, 2);

    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        this.setName("Bring glasses +1");
        this.setDescription("Gain 4 semester, lose two points of abilities after the end of your turn");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
