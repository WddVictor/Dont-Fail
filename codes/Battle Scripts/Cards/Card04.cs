using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card04 : Card
{
    private void Update()
    {
        this.setDamage(BattleControler.player.getShield());
    }

    void Start()
    {
        base.Awake();
        Debug.Log(BattleControler.player);
        base.init(Card.Attack, BattleControler.player.getShield(), 0, 1);

        this.setName("Killing in a dream");
        this.setDescription("Causing damage to your current chicken soup value");
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

        this.setName("Killing in a dream +1");
        this.setDescription("Causing damage to your current chicken soup value");

        this._updated = true;
    }
    public override void consume()
    {
        this.consumed = true;
    }
}
