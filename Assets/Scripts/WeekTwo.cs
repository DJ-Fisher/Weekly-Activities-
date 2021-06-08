using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwo : MonoBehaviour
{
    public string favGame ="Terraria";
    public int hoursPlayed = 700;
    public int cost = 14;
    public float valuePerHour;

    public int strength;
    public int agility;
    public int intelligence;
    public int statPoolTotal = 20;

    public bool heads = false;
    public bool tails = false;
    public bool draw = false;
    public string whoWon;

    // Start is called before the first frame update
    void Start()
    {
        valuePerHour = (float)hoursPlayed / (float)cost; 
        Debug.Log("my favourite game is " + favGame + " I've played it for " + hoursPlayed + " hours. I bought it for $" + cost + " therefore my cost per hour played is " + valuePerHour + ".");

        float randomFloatThingy = Random.Range(1, 10);
        
        Debug.Log(randomFloatThingy);

        if (randomFloatThingy == 1)
        {
            Debug.Log("the number was exactly one");
        }
        else if (randomFloatThingy > 3)
        {
            Debug.Log("The number was greater than three");
        }
        else if (randomFloatThingy < 3 || randomFloatThingy > 5)
        {
            if(randomFloatThingy == 4)
            {
                Debug.Log("The number was Exactly 4");
            }
            else
            {
                Debug.Log("the number was than three and greater than 5");
            }
        }
        else if(randomFloatThingy > 1 && randomFloatThingy < 5 || randomFloatThingy > 7)
        {
            Debug.Log("The number was greater than one and less than five, or it was greater than 7");
        }

        strength = strength + Random.Range(1, statPoolTotal);
        statPoolTotal = statPoolTotal - strength;
        Debug.Log("Strength is " + strength);

        agility = agility + Random.Range(1, statPoolTotal);
        statPoolTotal = statPoolTotal - agility;
        Debug.Log("Agility is " + agility);

        intelligence = intelligence + statPoolTotal;
        statPoolTotal = 0;
        Debug.Log("intelligence is " + intelligence);

        int coinFlippingSim = Random.Range(0,1000000);
        if (coinFlippingSim % 2 == 0)
        {
            whoWon = "Heads";
            Debug.Log("Coin landed on " + whoWon);
        }
        else if (coinFlippingSim == 69)
        {
            Debug.Log("Nice. It's a Draw");
        }
        else
        {
            Debug.Log("Coin landed on tails");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
