using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    public int ageYears;
    public int months;
    public int weeks;
    public int days;
    public int hours;
    public int minutes;
    public int seconds;

    public int strength;
    public int agility;
    public int intelligence;

    public float strengthMod = 2;
    public float agilityMod = 1.5f;
    public float intelligenceMod = 1;

    void Start()
    {
        strength = Random.Range(0, 11);
        agility = Random.Range(0, 11);
        intelligence = Random.Range(0, 11);

        FullName("DJ", "Fisher");
        AgeConversion();
        TriangleArea(Random.Range(0, 10), Random.Range(0, 10), 0);
        PowerLevel();
        BattleSimulator(0,0);
        
    }

    /// <summary>
    /// This function will print out the first and last name.
    /// </summary>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public void FullName(string firstName, string lastName)
    {
        print(firstName + " " + lastName + " age: " + ageYears);
    }

    public void AgeConversion()
    {
        months = ageYears * 12;
        weeks = months * 4;
        days = weeks * 7;
        hours = days * 24;
        minutes = hours * 60;
        seconds = minutes * 60;

        print("your age in years is equal to; " + months + " months, or " + weeks + " weeks, or " + days + " days, or " + hours + " hours, or " + minutes + " minutes, or even " + seconds + " seconds!");
    }

    /// <summary>
    /// Calculates the area of the triangle given the bease and height
    /// </summary>
    /// <param name="base_"></param>
    /// <param name="height_"></param>
    public void TriangleArea(int base_, int height_, float area)
    {
        area = (base_ * height_) / 2;
        print("The base of the triangle is " + base_ +  " meters and the height is " + height_ + " meters, therfore the area of the triangle is: " + area + "m^2");
    }

    public int PowerLevel()
    {
        print(((strength * 2) + (int)((float)agility * agilityMod) + intelligence));
        return ((strength * 2) + (int)((float)agility * agilityMod) + intelligence);
    }

    public void BattleSimulator(int playerOne, int playerTwo)
    {
        int p1Str = Random.Range(0,11);
        int p1Agi = Random.Range(0,11);
        int p1Int = Random.Range(0,11);
        float p1StrMod = 2;
        float p1AgiMod = 1.5f;
        float p1IntMod = 1;

        int p2Str = Random.Range(0, 11);
        int p2Agi = Random.Range(0, 11);
        int p2Int = Random.Range(0, 11);
        float p2StrMod = 2;
        float p2AgiMod = 1.5f;
        float p2IntMod = 1;

        playerOne = ((int)((float)p1Str * p1StrMod)) + ((int)((float)p1Agi * p1AgiMod)) + ((int)((float)p1Int * p1IntMod));
        playerTwo = ((int)((float)p2Str * p2StrMod)) + ((int)((float)p2Agi * p2AgiMod)) + ((int)((float)p2Int * p2IntMod));

        if(playerOne > playerTwo)
        {
            print("Player 1 beat player 2, player 1 had a total power level of " + playerOne + " wheras Player 2 had " + playerTwo + ".");
        }
        else if(playerTwo > playerOne)
        {
            print("Player 2 beat player 1, player 2 had a total power level of " + playerTwo + " wheras Player 1 had " + playerOne + ".");
        }
        else
        {
            print("it was a draw, both players had a total power level of " + playerOne);
        }
    }
}
