using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card17 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 16, 0, 2);

        this.setName("Watching notes");
        this.setDescription("Reduce the difficulty of 14 points, the scholastic ability to play 3 times on the card");

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
        base.init(Card.Attack, 18, 0, 2);
        this.setName("Watching notes +1");
        this.setDescription("Reduce the difficulty of 14 points, the scholastic ability to play 3 times on the card");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
