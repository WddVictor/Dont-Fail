using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card13 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 0, 0);
    }

    public override void play()
    {

        //attackMonster();
        //shieldPlayer();


        //获得2点学力,你的回合结束后,失去两点学力
        BattleControler.monster.addBuffLevel(0, 1);

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
