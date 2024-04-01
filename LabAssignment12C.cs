using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAssignment12C : MonoBehaviour
{
    int count;
    int secondNum;
    string card;
    int discardCard;

    List<string> _deck = new List<string>{"11 Spades", "12 Spades", "13 Spades", "14 Spades", "11 Hearts", "12 Hearts", "13 Hearts", "14 Hearts", "11 Clubs", "12 Clubs", "13 Clubs", "14 Clubs", "11 Diamonds", "12 Diamonds", "13 Diamonds", "14 Diamonds"};

    List<string> _hand = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
            {
                count = 16 - i;
                card = _deck[Random.Range(0,count)];
                _hand.Add(card);
                _deck.Remove(card);
            }

        Debug.Log("I made the initial deck and draw. My hand is: "+ _hand[0] + " , " + _hand[1]+ " , " +_hand[2]+ " , " +_hand[3]);
        
        for (int x = 0; x < 12; x++)
            {
                if(_hand.Contains("11 Spades") && _hand.Contains("12 Spades") && (_hand.Contains("13 Spades") || _hand.Contains("14 Spades")))
                {
                    Debug.Log("The game is WON  Spades");
                    return;
                }
                if(_hand.Contains("11 Hearts") && _hand.Contains("12 Hearts") && (_hand.Contains("13 Hearts") || _hand.Contains("14 Hearts")))
                {
                    Debug.Log("The game is WON  Hearts");
                    return;
                }
                if(_hand.Contains("11 Clubs") && _hand.Contains("12 Clubs") && (_hand.Contains("13 Clubs") || _hand.Contains("14 Clubs")))
                {
                    Debug.Log("The game is WON  Clubs");
                    return;
                }
                if(_hand.Contains("11 Diamonds") && _hand.Contains("12 Diamonds") && (_hand.Contains("13 Diamonds") || _hand.Contains("14 Diamonds")))
                {
                    Debug.Log("The game is WON  Diamonds");
                    return;
                }
                else
                {
                    Debug.Log("This is not a winning hand");

                    secondNum = 12 - x;

                    discardCard = (Random.Range(0,4));
                    Debug.Log("I discarded " +_hand[discardCard]);
                    _hand.RemoveAt(discardCard);


                    card = _deck[Random.Range(0,secondNum)];
                    _hand.Add(card);
                    Debug.Log("And Draw " + card);
                    _deck.Remove(card);

                    Debug.Log("My hand is: "+ _hand[0] + " , " + _hand[1]+ " , " +_hand[2]+ " , " +_hand[3]);
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
