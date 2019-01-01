using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card09 : Card
{
    private void Update()
    {
        this.setDamage(6 + CardController.instance.myCardList.Count);
    }

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 6, 0, 2);
        this.setName("Pre-test review");
        this.setDescription("Reduce the difficulty of 6 points, you have a card with a reduced difficulty value +1");

    }
    

    public override void play()
    {

        attackMonster();
        //shieldPlayer();

        //每有一张牌,降低的难度值+1

    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 8, 0, 2);
        this.setName("Pre-test review +1");
        this.setDescription("Reduce the difficulty of 8 points, you have a card with a reduced difficulty value +1");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
