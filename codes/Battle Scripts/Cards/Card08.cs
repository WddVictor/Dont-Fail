using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card08 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 9, 0, 1);

        this.setName("Look ahead");
        this.setDescription("Reduce the difficulty of 9 points, put a card in the discard pile on top of the draw pile");

    }

    public override void play()
    {

        attackMonster();

        //将弃牌堆里的一张牌放在抽牌堆顶部
        CardController.instance.unUsedCard.Add(CardController.instance.usedCard[0]);
        CardController.instance.usedCard.RemoveAt(0);
        CardController.instance.newCardLabel.text = CardController.instance.unUsedCard.Count.ToString();
        CardController.instance.usedCardLabel.text = CardController.instance.usedCard.Count.ToString();
    }

    public override void update()
    {
        if (this._updated)
        {
            return;
        }
        //完成该方法的升级
        base.init(Card.Attack, 11, 0, 1);

        this.setName("Look ahead +1");
        this.setDescription("Reduce the difficulty of 11 points, put a card in the discard pile on top of the draw pile");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
