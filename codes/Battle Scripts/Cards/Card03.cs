using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card03 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Skill, 0, 5, 1);
        this.setName("go to bed");
        this.setDescription("Get 5 chicken soup");
    }

    public override void play()
    {
 //       attackMonster();
        shieldPlayer();
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级

        base.init(Card.Skill, 0, 8, 1);
        this.setName("go to bed +1");
        this.setDescription("Get 8 chicken soup");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
