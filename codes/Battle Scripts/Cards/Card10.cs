using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card10 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 6, 0, 0);

        this.setName("Recursive review");
        this.setDescription("Reduce the difficulty of 6 points and put a copy of this card in the discard pile");

    }

    public override void play()
    {

        attackMonster();
        //shieldPlayer();


        //在弃牌堆放入一张此牌的复制品
        CardController.instance.usedCard.Add(this.gameObject);

        CardController.instance.usedCardLabel.text = CardController.instance.usedCard.Count.ToString();

    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级

        base.init(Card.Attack, 8, 0, 0);

        this.setName("Recursive review +1");
        this.setDescription("Reduce the difficulty of 8 points and put a copy of this card in the discard pile");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
