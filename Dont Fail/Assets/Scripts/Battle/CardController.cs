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

    public static List<GameObject> myCardList;
    public static List<GameObject> usedCard;
    public static List<GameObject> unUsedCard;


    public UILabel newCardLabel;
    public UILabel usedCardLabel;

    private void Awake()
    {
        InitCard();
        instance = this;
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            GetCard();
        if (Input.GetKeyDown(KeyCode.S)){
            UseCard();
        }
        if (Input.GetKeyDown(KeyCode.D))
            DisAllCards();
        if (Input.GetKeyDown(KeyCode.U))
            updateCard();
    }

    public static void updateCard(){
        if(myCardList.Count == 0){
            return;
        }else{
            myCardList[0].GetComponent<Card>().update();
        }
    }

    public void InitCard()
    {
        int cardNum;

        //从数据库取数据：
        unUsedCard = new List<GameObject>();
        usedCard = new List<GameObject>();
        myCardList = new List<GameObject>();

        List<string> library = new List<string>();
        library.Add("Card05");
        library.Add("Card05");
        library.Add("Card05");
        library.Add("Card05");


        
        cardNum = 10;
        newCardLabel.text = cardNum +"";
        
        for (int i = 0; i < cardNum; i++)
        {   
            GameObject newCard = NGUITools.AddChild(myCardArea, initNewCard);
            newCard.GetComponent<Transform>().localScale = new Vector3(1.5f, 1.5f);
            newCard.transform.Rotate(new Vector3(0, 0, -90));
            newCard.transform.position = card_start.position;
            var type  = System.Reflection.Assembly.Load("Assembly-CSharp").GetType((string)library[i%4]);
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
            iTween.MoveTo(myCardList[i], card_end.position + new Vector3(i * 0.3f - 1, 0), 1f);
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

    public void UseCard()
    {
        if (myCardList.Count == 0)
            return;
        Card candidate = myCardList[0].GetComponent<Card>();
        if(candidate.refreshMp()==false){
            return;
        }

        iTween.MoveTo(myCardList[0], card_end.position + new Vector3(-3, 0), 1f);
        usedCard.Add(myCardList[0]);
        myCardList.RemoveAt(0);

        for (int i = 0; i < myCardList.Count; i++)
            iTween.MoveTo(myCardList[i], card_end.position + new Vector3(i * 0.3f - 1, 0), 1f);
        
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

        newCardLabel.text = unUsedCard.Count.ToString();
        usedCardLabel.text = usedCard.Count.ToString();
    }
}
