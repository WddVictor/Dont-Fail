using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CardController : MonoBehaviour
{

    public static CardController instance;

    public  GameObject initNewCard;
    public  GameObject myCardArea;

    public Transform card_start;
    public Transform card_end;

    public List<GameObject> myCardList;
    public List<GameObject> usedCard;
    public List<GameObject> consumeCardList;
    public List<GameObject> unUsedCard;

    public UILabel newCardLabel;
    public UILabel usedCardLabel;
    public UILabel consumeCardLabel;

    private void Awake()
    {
        InitCard();
        instance = this;
    }



    public void updateCard(){
        if(myCardList.Count == 0){
            return;
        }else{
            myCardList[0].GetComponent<Card>().update();
        }
    }

    public void consumeCard(GameObject go)
    {
        for (int i = 0; i < myCardList.Count; i++)
            if (myCardList[i] == go)
            {
                myCardList.RemoveAt(i);
                consumeCardList.Add(go);
                go.transform.position = go.transform.position - new Vector3(0, 100);
                consumeCardLabel.text = consumeCardList.Count.ToString();
                return;
            }
    }

    public void InitCard()
    {
        int cardNum;

        //从数据库取数据：
        unUsedCard = new List<GameObject>();
        usedCard = new List<GameObject>();
        myCardList = new List<GameObject>();
        
        string[] library = Player.library;
        
        cardNum = 9;
        newCardLabel.text = cardNum +"";
        
        for (int i = 0; i < library.Length; i++)
        {   
            GameObject newCard = NGUITools.AddChild(myCardArea, initNewCard);
            newCard.GetComponent<Transform>().localScale = new Vector3(1.5f, 1.5f);
            newCard.transform.Rotate(new Vector3(0, 0, -90));
            newCard.transform.position = card_start.position;
            var type  = System.Reflection.Assembly.Load("Assembly-CSharp").GetType((string)library[i]);
            newCard.AddComponent(type);
            unUsedCard.Add(newCard);
        }
    }

    public void GetCard()
    {
        if (unUsedCard.Count == 0){
            return;
        }

        GameObject go = unUsedCard[0];
        go.transform.position = card_start.position;
        unUsedCard.RemoveAt(0);

        myCardList.Add(go);
        for (int i = 0; i < myCardList.Count; i++)
        {
            myCardList[i].transform.position = card_end.position + new Vector3(i * 0.35f - 1, 0);
        }

        ShuffleCards();

        newCardLabel.text = unUsedCard.Count.ToString(); 
        usedCardLabel.text = usedCard.Count.ToString();
    }

    public void ShuffleCards(){
        if (unUsedCard.Count == 0)
        {
            while (usedCard.Count != 0)
            {
                unUsedCard.Add(usedCard[0]);
                usedCard.RemoveAt(0);
            }
            newCardLabel.text = unUsedCard.Count.ToString();
            usedCardLabel.text = usedCard.Count.ToString();
            return;
        }
    }

    public void UseCard(GameObject go)
    {
        if (myCardList.Count == 0)
            return;
        Card candidate = go.GetComponent<Card>();
        if(candidate.refreshMp()==false){
            return;
        }

        go.transform.position = card_start.position;
        usedCard.Add(go);
        myCardList.Remove(go);

        for (int i = 0; i < myCardList.Count; i++)
            myCardList[i].transform.position = card_end.position + new Vector3(i * 0.35f - 1, 0);
        
        newCardLabel.text = unUsedCard.Count.ToString();
        usedCardLabel.text = usedCard.Count.ToString();

        candidate.play();
        ShuffleCards();

    }

    public void DisAllCards()
    {
        for (int i = myCardList.Count;  i > 0; i--)
        {
            iTween.MoveTo(myCardList[0], card_end.position + new Vector3(-3, 0), 1f);
            usedCard.Add(myCardList[0]);
            myCardList.RemoveAt(0);
        }
        ShuffleCards();

        newCardLabel.text = unUsedCard.Count.ToString();
        usedCardLabel.text = usedCard.Count.ToString();
    }
}
