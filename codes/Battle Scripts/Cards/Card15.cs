using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card15 : Card
{

    void Awake()
    {
        base.Awake();
        base.init(Card.Attack, 0, 0, 1);

        this.setName("put all one's eggs in one basket");
        this.setDescription("Hit the card at the top of the draw and consume it");

    }

    public override void play()
    {
        //attackMonster();
        //shieldPlayer();
       
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
        this.setName("put all one's eggs in one basket +1");
        this.setDescription("Hit the card at the top of the draw and consume it");


        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}