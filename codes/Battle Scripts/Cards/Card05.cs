using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card05 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 9, 0, 1);
        this.setName("Reading");
        this.setDescription("Reduce the difficulty of 9 points and draw a card");
    
    
    }

    public override void play()
    {

        attackMonster();
        CardController.instance.GetCard();
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级

        base.init(Card.Attack, 11, 0, 1);
        this.setName("Reading +1");
        this.setDescription("Reduce the difficulty of 11 points and draw a card");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
